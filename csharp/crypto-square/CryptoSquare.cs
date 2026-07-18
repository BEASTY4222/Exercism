using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public static class CryptoSquare
{
     public static string NormalizePlaintext(string input)
    {
        return new string(input
            .ToLower()
            .Where(char.IsLetterOrDigit)
            .ToArray());
    }

    public static string Ciphertext(string plaintext)
    {
        var normalized = NormalizePlaintext(plaintext);

        if (string.IsNullOrEmpty(normalized))
            return "";

        int length = normalized.Length;

        int c = (int)Math.Ceiling(Math.Sqrt(length));
        int r = (int)Math.Ceiling((double)length / c);

        // Build rows
        var rows = new List<string>();
        for (int i = 0; i < length; i += c)
        {
            rows.Add(normalized.Substring(i, Math.Min(c, length - i)));
        }

        // Read column-wise
        var result = new StringBuilder();

        for (int col = 0; col < c; col++)
        {
            for (int row = 0; row < r; row++)
            {
                if (col < rows[row].Length)
                    result.Append(rows[row][col]);
                else
                    result.Append(' ');
            }

            if (col < c - 1)
                result.Append(' ');
        }

        return result.ToString();
    }
}
