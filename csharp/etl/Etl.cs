public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> newDictionary = new Dictionary<string, int>();
        foreach (var elem in old)
        {
            for (int i = 0; i < elem.Value.Length; i++)
            {
                newDictionary[elem.Value[i].ToLower()] = elem.Key;
            }
        }
        
        return newDictionary;
    }
}