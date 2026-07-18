public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;

        input = input.ToUpper();

        for (int i = 0;i < input.Length;i++)
        {
            switch (input[i])
            {
                case 'A' or 'E' or 'I' or 'O' or 'U' or 'L' or 'N' or 'R' or 'S' or 'T':
                    score += 1;
                    break;
                case 'D' or 'G':
                    score += 2;
                    break;
                case 'B' or 'C' or 'M' or 'P': 
                    score += 3;
                    break;
                case 'F' or 'H' or 'V' or 'W' or 'Y':
                    score += 4;
                    break;
                case 'K':
                    score += 5;
                    break;
                case 'J' or 'X':
                    score += 8;
                    break;
                case 'Q' or 'Z':
                    score += 10;
                    break;
            }
        }

        return score;
    }
}