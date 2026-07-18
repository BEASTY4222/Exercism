public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int eggCount = 0;

        while (encodedCount > 0)
        {
            if(encodedCount % 2 == 1) eggCount++;
            encodedCount /= 2;  
        }

        return eggCount;
    }
}
