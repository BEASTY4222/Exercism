public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<char> uniqeLetters = new HashSet<char>();
        word = word.ToLower();

        foreach (char letter in word)
        {
            if(letter == ' ' || letter == '-') continue;
            if(!uniqeLetters.Add(letter)) return false;
            else uniqeLetters.Add(letter);
        }

        return true;
    }
}
