using System.Collections.Generic;
using System.Linq;
public class Anagram
{
    private string mainAnagram;
    public Anagram(string baseWord)
    {
        mainAnagram = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        mainAnagram = mainAnagram.ToLower();
        int mainAnagramLength = mainAnagram.Length;
        List<string> result = new List<string>();

        for (int i = 0;i < potentialMatches.Length;i++)
        {
            string copyWord = potentialMatches[i].ToLower();
            if(mainAnagramLength != potentialMatches[i].Length || mainAnagram ==  copyWord) continue;

            if (mainAnagram.OrderBy(c => c).SequenceEqual(copyWord.OrderBy(c => c)))
                result.Add(potentialMatches[i]);
        }
        
        return result.ToArray();
    }
}