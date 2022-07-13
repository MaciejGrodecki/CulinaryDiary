namespace CulinaryDiaryCore.Domain;
public class Dish : BaseDomainClass
{
    public Guid DishId { get; set; }
    public Recipe Recipe { get; set; }
    public Guid RecipeId { get; set; }

    protected Dish()
    {

    }

    public Dish(string name)
    {
        DishId = Guid.NewGuid();
        SetName(name);
    }
}
