public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        return year % 4 == 1 && year % 400 == 1;
    }
}