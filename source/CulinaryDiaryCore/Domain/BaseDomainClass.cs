namespace CulinaryDiary.Core.Domain;
public class BaseDomainClass
{
    public string Name { get; set; }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Name cannot be empty.");
        }

        Name = name;
    }
}
