using CulinaryDiaryCore.Enums;

namespace CulinaryDiaryCore.Domain;

public class Ingredient : BaseDomainClass
{
    public Guid IngredientId { get; set; }
    public double Quantity { get; set; }
    public QuantityType QuantityType { get; set; }

    protected Ingredient()
    {

    }

    public Ingredient(string name, double quantity, QuantityType quantityType)
    {
        IngredientId = Guid.NewGuid();
        SetName(name);
        SetQuantity(quantity);
        QuantityType = quantityType;
    }

    public void SetQuantity(double quantity)
    {
        if (quantity <= 0)
        {
            throw new Exception("Quantity must be higher than zero.");
        }

        Quantity = quantity;
    }
}
