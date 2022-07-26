using CulinaryDiary.Core.Enums;

namespace CulinaryDiary.Core.Domain;

public class Ingredient : BaseDomainClass
{
    public Guid IngredientId { get; set; }
    public double Quantity { get; set; }
    public QuantityType QuantityType { get; set; }
    public Recipe Recipe { get; set; }

    protected Ingredient()
    {

    }

    public Ingredient(string name, double quantity, QuantityType quantityType, Recipe recipe)
    {
        IngredientId = Guid.NewGuid();
        SetName(name);
        SetQuantity(quantity);
        QuantityType = quantityType;
        SetRecipe(recipe);
    }

    public void SetRecipe(Recipe recipe)
    {
        if (recipe == null)
        {
            throw new Exception("You must specify recipe, it cannot be null.");
        }

        Recipe = recipe;
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
