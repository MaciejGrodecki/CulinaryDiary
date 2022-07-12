namespace CulinaryDiaryCore.Repositories;

public interface IIngredientRepository
{
    Task<IEnumerable<Ingredient>> GetAllAsync();
    Task<Ingredient> GetAsync(Guid ingredientId);
    Task AddAsync(Ingredient ingredient);
    Task UpdateAsync(Ingredient ingredient);
    Task DeleteAsync(Guid ingredientId);
}
