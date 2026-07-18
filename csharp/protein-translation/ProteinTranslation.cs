using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<string> result = new List<string>();
        string[] codons = new string[strand.Length / 3];
        int c = 0,i = 0;
        while(c < strand.Length)
        {
            codons[i] = strand.Substring(c,3);

            c+=3;
            i++;
        }

        foreach(string codon in codons)
        {
            switch (codon)
            {
                case "AUG": result.Add("Methionine"); break;
                case "UUU" or "UUC": result.Add("Phenylalanine"); break;
                case "UUA" or "UUG": result.Add("Leucine"); break;
                case "UCU" or "UCC" or "UCA" or "UCG": result.Add("Serine"); break;
                case "UAU" or "UAC": result.Add("Tyrosine"); break;
                case "UGU" or "UGC": result.Add("Cysteine"); break;
                case "UGG": result.Add("Tryptophan"); break;
                case "UAA" or "UAG" or "UGA": return result.ToArray(); break;
            }
        }

        return result.ToArray();
    }
}