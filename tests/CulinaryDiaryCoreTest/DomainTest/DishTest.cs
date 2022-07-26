namespace CulinaryDiaryCore.Test.DomainTest;
public class DishTest
{
    [Theory]
    [MemberData(nameof(CorrectDish))]
    public void DishObjectShouldBeCreated(string name, Guid recipeId)
    {
        var dish = new Dish(name, recipeId);

        Assert.NotNull(dish);
    }

    [Theory]
    [MemberData(nameof(IncorrectDishWithEmptyNameOrNull))]
    public void DishWithEmptyOrNullNameShouldThrowException(string name, Guid recipeId)
    {
        Exception exception = Assert.Throws<Exception>(() => new Dish(name, recipeId));

        Assert.Equal("Name cannot be empty.", exception.Message);
    }

    public static IEnumerable<object[]> CorrectDish =>
        new List<object[]>
        {
            new object[] {"Test dish", "293433f2-78e5-4356-9528-e14c6b8b96f6" }
        };

    public static IEnumerable<object[]> IncorrectDishWithEmptyNameOrNull =>
        new List<object[]>
        {
            new object[] {"", "293433f2-78e5-4356-9528-e14c6b8b96f6" },
            new object[] {null, "293433f2-78e5-4356-9528-e14c6b8b96f6" }
        };
}
