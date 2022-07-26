namespace CulinaryDiary.Core.Repositories;

public interface IIngredientRepository
{
    Task<IEnumerable<Ingredient>> GetAllAsync();
    Task<IEnumerable<Ingredient>> GetAllAsync(Recipe recipe);
    Task<Ingredient> GetAsync(Guid ingredientId);
    Task AddAsync(Ingredient ingredient);
    Task UpdateAsync(Ingredient ingredient);
    Task DeleteAsync(Ingredient ingredient);
}
