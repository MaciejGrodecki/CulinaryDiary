namespace CulinaryDiaryCore.Test.DomainTest;

public class IngredientTest
{

    [Theory]
    [MemberData(nameof(CorrectIngredient))]
    public void IngredientObjectShouldBeCreated(string name, double quantity, QuantityType quantityType, Recipe recipe)
    {
        var ingredient = new Ingredient(name, quantity, quantityType, recipe);

        Assert.NotNull(ingredient);
    }

    [Theory]
    [MemberData(nameof(IncorrectNameIngredient))]
    public void IngredientWithEmptyNameShouldNotBeCreated(
        string name,
        double quantity,
        QuantityType quantityType,
        Recipe recipe)
    {
        Exception exception = Assert.Throws<Exception>(() => new Ingredient(name, quantity, quantityType, recipe));

        Assert.Equal("Name cannot be empty.", exception.Message);
    }

    [Theory]
    [MemberData(nameof(IncorrectQuantityIngredient))]
    public void IngredientWithZeroOrLessQuantityShouldNotBeCreated(
        string name,
        double quantity,
        QuantityType quantityType,
        Recipe recipe)
    {
        Exception exception = Assert.Throws<Exception>(() => new Ingredient(name, quantity, quantityType, recipe));

        Assert.Equal("Quantity must be higher than zero.", exception.Message);
    }

    [Theory]
    [MemberData(nameof(IncorrectRecipeIngredient))]
    public void IngredientWithNullRecipeShouldThrowException(
        string name,
        double quantity,
        QuantityType quantityType,
        Recipe recipe)
    {
        Exception exception = Assert.Throws<Exception>(() => new Ingredient(name, quantity, quantityType, recipe));

        Assert.Equal("You must specify recipe, it cannot be null.", exception.Message);
    }

    public static IEnumerable<object[]> CorrectIngredient =>
        new List<object[]>
        {
            new object[] { "Garlic", 1.5, QuantityType.Piece, new Recipe("description") }
        };

    public static IEnumerable<object[]> IncorrectNameIngredient =>
        new List<object[]>
        {
            new object[] { "", 1.5, QuantityType.Piece, new Recipe("description") },
            new object[] {null, 1.5, QuantityType.Piece, new Recipe("description") }
        };

    public static IEnumerable<object[]> IncorrectQuantityIngredient =>
        new List<object[]>
        {
            new object[] { "Garlic", 0, QuantityType.Piece, new Recipe("description") },
            new object[] { "Garlic", -1, QuantityType.Piece, new Recipe("description") }
        };

    public static IEnumerable<object[]> IncorrectRecipeIngredient =>
        new List<object[]>()
        {
            new object[] { "Garlic", 5, QuantityType.Piece, null }
        };
}
