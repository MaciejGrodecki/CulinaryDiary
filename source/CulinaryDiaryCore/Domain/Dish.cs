namespace CulinaryDiaryCore.Domain;
public class Dish : BaseDomainClass
{
    public Guid DishId { get; set; }

    protected Dish()
    {

    }

    public Dish(string name)
    {
        DishId = Guid.NewGuid();
        SetName(name);
    }
}
