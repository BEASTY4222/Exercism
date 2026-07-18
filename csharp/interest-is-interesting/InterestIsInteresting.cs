static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float rate = 0f;

        if (balance < 0m)
        {
            rate = 3.213f;
        }else if (balance < 1000m)
        {
            rate = 0.5f;
        }else if (balance >= 1000m && balance < 5000m)
        {
            rate = 1.621f;
        }else
        {
            rate = 2.475f;
        }
        
        return rate;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance) / 100m;    
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yearsNeeded = 0;

        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            yearsNeeded++;
        }


        return yearsNeeded;
    }
}
