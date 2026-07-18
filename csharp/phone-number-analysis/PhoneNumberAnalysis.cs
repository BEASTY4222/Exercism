public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        (bool IsNewYork, bool IsFake, string LocalNumber) result;

        string phoneNumberCopyIsNewYork = phoneNumber;
        string phoneNumberCopyIsFake = phoneNumber;


        if(phoneNumberCopyIsNewYork.Substring(0,3) == "212") result.IsNewYork = true;
        else result.IsNewYork = false;

        result.LocalNumber = phoneNumber.Substring(phoneNumber.Length - 4);

        if (phoneNumberCopyIsFake.Substring(4, 3) == "555") result.IsFake = true;
        else result.IsFake = false;

        return result;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
