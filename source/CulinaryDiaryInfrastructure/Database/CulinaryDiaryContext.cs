using Microsoft.Extensions.Options;

namespace CulinaryDiary.Infrastructure.Database;
public class CulinaryDiaryContext : DbContext
{
    private SqlServerSettings _settings;

    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }

    public CulinaryDiaryContext(DbContextOptions<CulinaryDiaryContext> options, IOptions<SqlServerSettings> settings)
        : base(options)
    {
        _settings = settings.Value;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            _settings.ConnectionString,
            x => x.MigrationsAssembly("CulinaryDiaryInfrastructure")
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var dishBuilder = modelBuilder.Entity<Dish>().ToTable("Dishes");
        dishBuilder.HasKey(i => i.DishId);

        var ingredientBuilder = modelBuilder.Entity<Ingredient>().ToTable("Ingredients");
        ingredientBuilder.HasKey(i => i.IngredientId);

        var recipeBuilder = modelBuilder.Entity<Recipe>().ToTable("Recipes");
        recipeBuilder.HasKey(i => i.RecipeId);
        recipeBuilder.HasMany(i => i.Ingredients).WithOne(r => r.Recipe);
        recipeBuilder.HasOne(d => d.Dish).WithOne(r => r.Recipe).HasForeignKey<Dish>(r => r.RecipeId);
    }
}
