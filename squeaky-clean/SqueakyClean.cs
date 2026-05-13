using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        string result = identifier;

        if (result == "") return "";
        
        if(result.contains(" "))  result = result.Replace(" ","_");
        
        result = Regex.Replace(result, @"\p{C}", "CTRL");



    }
}
