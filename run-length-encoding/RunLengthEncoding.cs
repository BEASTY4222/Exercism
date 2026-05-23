public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if(String.IsNullOrEmpty(input)) return input;
        string result = "";
        int letterCount = 0;
        char currLetter = input[0];
        foreach(char letter in input)
        {
            if(letter == currLetter)
            {
                letterCount++;
            }
            else
            {
                result += letterCount > 1 ? letterCount : "";
                result += currLetter;
                currLetter = letter;
                letterCount = 1;
            }
        }
        if(currLetter == input.Last())
        {
            result += letterCount > 1 ? letterCount : "";
            result += currLetter;
        }

        return result;
    }

    public static string Decode(string input)
    {
        if (!input.Any(Char.IsDigit)) return input;
        

        string result = "";

        for(int i = 0;i < input.Length-1;i++)
        {
            if (Char.IsDigit(input[i]) && Char.IsDigit(input[i+1]))
            {
                result += new string(input[i+2],Convert.ToInt32(input.Substring(i,2)));
                i+=2;
            }
            else if (Char.IsDigit(input[i]))
            {
                result += new string(input[i+1],input[i] - '0');
                i++;
            }else
            {
                result += input[i];
            }
        }
        if (result.Last() != input.Last())
        {
            result += input.Last();
        }
        
        return result;
    }
}
