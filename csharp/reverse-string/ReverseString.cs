using System.Collections.Generic;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string result = "";
        Stack<char> chars = new Stack<char>();
        foreach(char letter in input) chars.Push(letter);
        foreach(char letter in chars) result += letter;
        return result;
    }
}