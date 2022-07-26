namespace CulinaryDiary.Core.Repositories;

public interface IDishRepository
{
    Task<IEnumerable<Dish>> GetAllAsync();
    Task<Dish> GetAsync(Recipe recipe);
    Task<Dish> GetAsync(Guid dishId);
    Task AddAsync(Dish dish);
    Task UpdateAsync(Dish dish);
    Task DeleteAsync(Dish dish);
}
