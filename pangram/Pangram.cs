public static class Pangram
{
    public static bool IsPangram(string input)
    {
        HashSet<char> letters = input.ToLower().ToHashSet();
    
        foreach (char letter in letters) if(!Char.IsLetter(letter)) letters.Remove(letter);

        return letters.Count == 26;
    }
}
