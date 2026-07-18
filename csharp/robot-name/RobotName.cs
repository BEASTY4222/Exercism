public class Robot
{
    private string? name;
    private static HashSet<string> usedNames = new();
    private static Random random = new();
    public string Name
    {
        get
        {
            if (name == null)
            {
                name = genName();
            }
            
            return name;
        }
    }

    public void Reset()
    {
        name = null;
    }

    private string genName()
    {
        string newName;
        do
        {
            char firstLetter = (char)random.Next('A', 'Z' + 1);
            char secondLetter = (char)random.Next('A', 'Z' + 1);
            int numbers = random.Next(0, 1000);
        
            newName = $"{firstLetter}{secondLetter}{numbers:D3}";
        }
        while (usedNames.Contains(newName));
        
        usedNames.Add(newName);
        name = newName;

        return newName;
    }
}