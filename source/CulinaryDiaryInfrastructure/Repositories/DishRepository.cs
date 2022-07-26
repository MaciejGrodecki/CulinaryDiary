namespace CulinaryDiary.Infrastructure.Repositories;

public class DishRepository : IDishRepository
{
    private readonly CulinaryDiaryContext _context;

    public DishRepository(CulinaryDiaryContext context)
    {
        _context = context;
    }

    public Task DeleteAsync(Dish dish)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Dish> GetAsync(Recipe recipe)
    {
        throw new NotImplementedException();
    }

    public Task<Dish> GetAsync(Guid dishId)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Dish dish)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Dish dish)
    {
        throw new NotImplementedException();
    }
}
