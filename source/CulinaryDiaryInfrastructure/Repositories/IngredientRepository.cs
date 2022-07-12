using CulinaryDiaryCore.Domain;

namespace CulinaryDiaryInfrastructure.Repositories;

public class IngredientRepository : IIngredientRepository
{
    public Task<IEnumerable<Ingredient>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Ingredient> GetAsync(Guid ingredientId)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Ingredient ingredient)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Ingredient ingredient)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid ingredientId)
    {
        throw new NotImplementedException();
    }
}
