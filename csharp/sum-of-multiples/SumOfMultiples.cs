public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> myMultiples = new HashSet<int>();
        int i, sum = 0;
        
        foreach (int multiple in multiples)
        {
            i = 1;
			if (multiple == 0) continue;

            while (i < max)
            {
                
                
                if (i % multiple == 0 && i < max) myMultiples.Add(i);

                i++;
            }
        }

        foreach (int number in myMultiples) sum +=  number;
        
        return sum;
    }
}