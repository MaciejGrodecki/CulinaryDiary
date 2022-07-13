using Microsoft.Extensions.Options;

namespace CulinaryDiaryInfrastructure.Database;
public class CulinaryDiaryContext : DbContext
{
    private SqlServerSettings _settings;

    public DbSet<Dish> Dishes;
    public DbSet<Ingredient> Ingredients;

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
    }
}
