public static class Bob
{
    public static string Response(string statement)
    {
        bool silence = string.IsNullOrWhiteSpace(statement);

        bool question = statement.TrimEnd().EndsWith("?");

        bool hasLetters = statement.Any(char.IsLetter);

        bool allCaps = hasLetters &&
                       statement.Where(char.IsLetter).All(char.IsUpper);

        if (allCaps && question)
            return "Calm down, I know what I'm doing!";

        if (allCaps)
            return "Whoa, chill out!";

        if (question)
            return "Sure.";

        if (silence)
            return "Fine. Be that way!";

        return "Whatever.";
    }
}