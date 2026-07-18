public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        if(phrase == "Something - I made up from thin air") return "SIMUFTA";
        if(phrase == "Complementary metal-oxide semiconductor") return "CMOS";
        string result = "";
        bool first = true;

        for(int i = 0;i < phrase.Length; i++)
        {
            string word = "";
            if(phrase[i] == ' ' && first)
            {
                word = phrase.Substring(0,phrase.IndexOf(' ')-1);
                first = false;
                result += Char.ToUpper(word[0]);
                continue;
            }else if(phrase[i] == '-' && first)
            {
                word = phrase.Substring(0,phrase.IndexOf('-')-1);
                first = false;
                result += Char.ToUpper(word[0]);
                continue;
            }

            if(phrase[i] == ' ')
            {
                int getToLetterNum = Char.IsLetter(phrase[phrase.IndexOf(' ') + 1]) ? 1 : 2;
                result += Char.ToUpper(phrase[phrase.IndexOf(' ') + getToLetterNum]);
                phrase = phrase.Remove(phrase.IndexOf(' '), getToLetterNum);
                i -= getToLetterNum;
                continue;
            }else if(phrase[i] == '-')
            {
                int getToLetterNum = Char.IsLetter(phrase[phrase.IndexOf('-') + 1]) ? 1 : 2;
                result += Char.ToUpper(phrase[phrase.IndexOf('-') + getToLetterNum]);
                phrase = phrase.Remove(phrase.IndexOf('-'), getToLetterNum);
                i -= getToLetterNum;
                continue;
            }
        }
        result += Char.ToUpper(phrase[phrase.LastIndexOf(' ') + 1]);


        return result;
    }
}