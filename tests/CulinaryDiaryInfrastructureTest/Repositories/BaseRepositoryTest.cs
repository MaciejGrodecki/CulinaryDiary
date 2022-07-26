namespace CulinaryDiary.Infrastructure.Test.Repositories;
public class BaseRepositoryTest
{
    protected readonly InMemoryTestContext _context;
    public BaseRepositoryTest()
    {
        _context = ContextSetup.GetInMemoryTestContext();
        PopulateIngredientsWithData();
    }

    private void PopulateIngredientsWithData()
    {
        var recipe = new Recipe("desc");

        _context.Ingredients.Add(
            new Ingredient("ing_1", 1.0, Core.Enums.QuantityType.Kilogram, recipe));

        _context.Ingredients.Add(
            new Ingredient("ing_2", 1.0, Core.Enums.QuantityType.Kilogram, recipe));

        _context.SaveChanges();
    }
}
