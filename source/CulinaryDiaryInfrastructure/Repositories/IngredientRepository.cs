namespace CulinaryDiaryInfrastructure.Repositories;

public class IngredientRepository : IIngredientRepository
{
    private readonly CulinaryDiaryContext _context;

    public IngredientRepository(CulinaryDiaryContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Ingredient>> GetAllAsync()
    {
        return await Task.FromResult(_context.Ingredients);
    }

    public async Task<IEnumerable<Ingredient>> GetAllAsync(Recipe recipe)
    {
        return await Task.FromResult(_context.Ingredients.Where(ingredient => ingredient.Recipe == recipe));
    }

    public async Task<Ingredient> GetAsync(Guid ingredientId)
    {
        return await Task.FromResult(
            _context.Ingredients.SingleOrDefault(ingredient => ingredient.IngredientId == ingredientId)
        );
    }

    public async Task AddAsync(Ingredient ingredient)
    {
        await _context.Ingredients.AddAsync(ingredient);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Ingredient ingredient)
    {
        _context.Ingredients.Update(ingredient);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Ingredient ingredient)
    {
        _context.Ingredients.Remove(ingredient);
        await _context.SaveChangesAsync();
    }
}
