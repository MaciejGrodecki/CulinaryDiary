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

    [Fact]
    public async void AddAsyncShouldAddSingleIngredient()
    {
        var recipe = new Recipe("Soup test recipe");
        var ingredient = new Ingredient("Salt", 5.0, CulinaryDiaryCore.Enums.QuantityType.Gram, recipe);

        IngredientRepository repo = new IngredientRepository(_context);

        await repo.AddAsync(ingredient);

        var addedIngredient = await repo.GetAsync(ingredient.IngredientId);

        Assert.Equal(addedIngredient, ingredient);
    }

}
