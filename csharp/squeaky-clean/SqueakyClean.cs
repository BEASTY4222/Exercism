using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var result = new StringBuilder();
        bool makeUpper = false;
        
        foreach (char c in identifier)
        {
            if (char.IsControl(c))
            {
                result.Append("CTRL");
                continue;
            }
            if (c == ' ')
            {
                result.Append('_');
                continue;
            }
            
            // Skip kebab-case dash and capitalize next letter
            if (c == '-')
            {
                makeUpper = true;
                continue;
            }

            // Omit non-letters
            if (!char.IsLetter(c))
            {
                continue;
            }

            // Omit Greek lowercase letters α to ω
            if (c >= 'α' && c <= 'ω')
            {
                continue;
            }

            // Convert next character to uppercase after '-'
            if (makeUpper)
            {
                result.Append(char.ToUpper(c));
                makeUpper = false;
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}
