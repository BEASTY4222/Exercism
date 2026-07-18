using System.Formats.Asn1;

public static class LineUp
{
    public static string Format(string name, int number)
    {
        string numberStr = number.ToString();
        string result = "";

        if (numberStr.Last() >= '4' || numberStr == "112" || numberStr == "10" || numberStr == "100" || numberStr == "11" || numberStr == "12" || numberStr == "13") 
            result = name + ", you are the "+ number +"th customer we serve today. Thank you!";
        else if(numberStr.Last() == '1') result = name + ", you are the "+ number +"st customer we serve today. Thank you!";
        else if(numberStr.Last() == '2') result = name + ", you are the "+ number +"nd customer we serve today. Thank you!";
        else if(numberStr.Last() == '3') result = name + ", you are the "+ number +"rd customer we serve today. Thank you!";

        return result;
    }
}
