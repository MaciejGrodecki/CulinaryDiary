using CulinaryDiaryInfrastructure.Repositories;

namespace CulinaryDiary.Infrastructure.Test.Repositories;
public class IngredientRepositoryTests : BaseRepositoryTest
{
    public IngredientRepositoryTests()
        : base()
    {
    }

    [Fact]
    public async void GetAllAsyncShouldReturnAllIngredients()
    {
        IngredientRepository repo = new IngredientRepository(_context);

        var ingredients = await repo.GetAllAsync();

        Assert.Equal(2, ingredients.Count());
    }

}
