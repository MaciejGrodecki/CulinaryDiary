namespace CulinaryDiaryCore.Domain;
public class Recipe
{
    public Guid RecipeId { get; set; }
    public Dish Dish { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; }
    public string Description { get; set; }

    protected Recipe()
    {

    }

    public Recipe(string description)
    {

    }

    public void SetDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new Exception("Description cannot be empty.");
        }

        Description = description;
    }
}
