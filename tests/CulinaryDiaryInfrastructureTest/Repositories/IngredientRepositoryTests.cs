using CulinaryDiaryCore.Domain;
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

    [Fact]
    public async void GetAllAsyncShouldReturnAllRecipesIngredients()
    {
        IngredientRepository repo = new IngredientRepository(_context);

        var ingredients = await repo.GetAllAsync();
        var recipe = ingredients.Select(x => x.Recipe).FirstOrDefault();

        var recipeIngredients = await repo.GetAllAsync(recipe);

        Assert.Equal(2, recipeIngredients.Count());

    }

    [Fact]
    public async void GetAsyncShouldReturnSingleIngredient()
    {
        IngredientRepository repo = new IngredientRepository(_context);

        var ingredients = await repo.GetAllAsync();

        var ingredient = ingredients.Select(x => x).FirstOrDefault();

        var selectedIngredient = await repo.GetAsync(ingredient!.IngredientId);

        Assert.Equal(selectedIngredient, ingredient);
    }

}
