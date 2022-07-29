namespace CulinaryDiary.Core.Repositories;
public interface IRecipeRepository
{
    Task<IEnumerable<Recipe>> GetAllAsync();
    Task<Recipe> GetAsync(Guid recipeId);
    Task<Recipe> GetAsync(Dish dish);
    Task AddAsync(Recipe recipe);
    Task UpdateAsync(Recipe recipe);
    Task DeleteAsync(Recipe recipe);
}
