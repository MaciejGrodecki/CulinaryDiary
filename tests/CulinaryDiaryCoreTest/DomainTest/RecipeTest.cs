namespace CulinaryDiaryCoreTest.DomainTest;
public class RecipeTest
{
    [Theory]
    [MemberData(nameof(CorrectRecipeObject))]
    public void RecipeObjectShouldBeCreated(string description)
    {
        var recipe = new Recipe(description);

        Assert.NotNull(recipe);
    }

    [Theory]
    [MemberData(nameof(IncorrectRecipeWithEmptyOrNullDescription))]
    public void RecipeWithEmptyOrNullDescriptionShouldThrowException(string description)
    {
        Exception exception = Assert.Throws<Exception>(() => new Recipe(description));

        Assert.Equal("Description cannot be empty.", exception.Message);
    }

    public static IEnumerable<object[]> CorrectRecipeObject =>
        new List<object[]>
        {
            new object[]{ "description" }
        };

    public static IEnumerable<object[]> IncorrectRecipeWithEmptyOrNullDescription =>
        new List<object[]>
        {
            new object[] { "" },
            new object[] { null }
        };
}
