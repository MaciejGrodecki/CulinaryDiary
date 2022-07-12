using CulinaryDiaryCore.Enums;

namespace CulinaryDiaryCore.Domain;

public class Ingredient
{
    public Guid IngredientId { get; set; }
    public string Name { get; set; }
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

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Name cannot be empty.");
        }

        Name = name;
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
