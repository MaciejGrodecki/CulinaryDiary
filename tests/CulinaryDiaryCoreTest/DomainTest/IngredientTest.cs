namespace CulinaryDiaryCoreTest.DomainTest;

public class IngredientTest
{
    [Theory]
    [InlineData("Garlic", 1.5, QuantityType.Piece)]
    public void IngredientObjectShouldBeCreated(string name, double quantity, QuantityType quantityType)
    {
        var ingredient = new Ingredient(name, quantity, quantityType);

        Assert.NotNull(ingredient);
    }

    [Theory]
    [InlineData("", 1.5, QuantityType.Piece)]
    [InlineData(null, 1.5, QuantityType.Piece)]
    public void IngredientWithEmptyNameShouldNotBeCreated(string name, double quantity, QuantityType quantityType)
    {
        Exception exception = Assert.Throws<Exception>(() => new Ingredient(name, quantity, quantityType));

        Assert.Equal("Name cannot be empty.", exception.Message);
    }

    [Theory]
    [InlineData("Garlic", 0, QuantityType.Piece)]
    [InlineData("Garlic", -1, QuantityType.Piece)]
    public void IngredientWithZeroOrLessQuantityShouldNotBeCreated(
        string name,
        double quantity,
        QuantityType quantityType)
    {
        Exception exception = Assert.Throws<Exception>(() => new Ingredient(name, quantity, quantityType));

        Assert.Equal("Quantity must be higher than zero.", exception.Message);
    }
}
