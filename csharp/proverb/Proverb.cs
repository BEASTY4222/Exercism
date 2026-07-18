public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> result = new List<string>();
        for(int i = 0;i < subjects.Length;i++)
        {
            if(subjects[i] == subjects[subjects.Length-1]) result.Add("And all for the want of a "+subjects[0]+".");
            else result.Add("For want of a "+ subjects[i] +" the "+ subjects[i + 1] +" was lost.");
        }

        return result.ToArray();
    }
}