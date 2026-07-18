using System;
using System.Linq;

public static class PigLatin
{
    public static string Translate(string phrase)
    {
        return string.Join(" ", phrase.Split(' ').Select(TranslateWord));
    }

    private static string TranslateWord(string word)
    {
        // Rule 1: starts with vowel OR "xr" OR "yt"
        if (StartsWithVowel(word) || word.StartsWith("xr") || word.StartsWith("yt"))
        {
            return word + "ay";
        }

        // Rule 3: consonants + "qu"
        int quIndex = word.IndexOf("qu");
        if (quIndex != -1 && IsAllConsonants(word.Substring(0, quIndex)))
        {
            return word.Substring(quIndex + 2) + word.Substring(0, quIndex + 2) + "ay";
        }

        // Rule 4: consonants followed by 'y'
        int yIndex = word.IndexOf('y');
        if (yIndex > 0 && IsAllConsonants(word.Substring(0, yIndex)))
        {
            return word.Substring(yIndex) + word.Substring(0, yIndex) + "ay";
        }

        // Rule 2: leading consonant cluster
        int i = 0;
        while (i < word.Length && !IsVowel(word[i]))
        {
            i++;
        }

        return word.Substring(i) + word.Substring(0, i) + "ay";
    }

    private static bool IsVowel(char c)
    {
        return "aeiou".Contains(c);
    }

    private static bool StartsWithVowel(string word)
    {
        return IsVowel(word[0]);
    }

    private static bool IsAllConsonants(string s)
    {
        return s.All(c => !IsVowel(c));
    }
}