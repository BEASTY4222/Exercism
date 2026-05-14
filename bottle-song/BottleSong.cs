using System.Collections.Generic;

public static class BottleSong
{
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        List<string> result = new List<string>();

        string[] numbers =
        {
            "no",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten"
        };

        for (int i = startBottles; i > startBottles - takeDown; i--)
        {
            string currentBottle = i == 1 ? "bottle" : "bottles";
            string nextBottle = (i - 1) == 1 ? "bottle" : "bottles";

            result.Add($"{numbers[i]} green {currentBottle} hanging on the wall,");
            result.Add($"{numbers[i]} green {currentBottle} hanging on the wall,");
            result.Add("And if one green bottle should accidentally fall,");
            result.Add($"There'll be {numbers[i - 1].ToLower()} green {nextBottle} hanging on the wall.");

            // blank line between verses
            if (i > startBottles - takeDown + 1)
            {
                result.Add("");
            }
        }

        return result;
    }
}