public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        //101 => CI
        // max MMMCMXCIX => 3999
        string result = "";
        string strValue = Convert.ToString(value);
        int counter = 0;
        while(value != 0 || counter > 100)
        {
            if(value - 1000 >= 0)
            {
                value -= 1000;
                result += 'M';
            }else if (value - 900 >= 0)
            {
                value -= 900;
                result += "CM";
            }
            else if (value - 500 >= 0)
            {
                value -= 500;
                result += 'D';
            }else if (value - 400 >= 0)
            {
                value -= 400;
                result += "CD";
            }
            else if (value - 100 >= 0)
            {
                value -= 100;
                result += 'C';
            }else if (value - 90 >= 0)
            {
                value -= 90;
                result += "XC";
            }
            else if(value - 50 >= 0)
            {
                value -= 50;
                result += 'L';
            }else if (value - 40 >= 0)
            {
                value -= 40;
                result += "XL";
            }
            else if (value - 10 >= 0)
            {
                value -= 10;
                result += 'X';
            }else if (value - 9 >= 0)
            {
                value -= 9;
                result += "IX";
            }else if (value - 8 >= 0)
            {
                value -= 8;
                result += "VIII";
            }else if (value - 7 >= 0)
            {
                value -= 7;
                result += "VII";
            }else if(value - 6 >= 0)
            {
                value -= 6;
                result += "VI";
            }else if (value - 5 >= 0)
            {
                value -= 5;
                result += 'V';
            }else if (value - 4 >= 0)
            {
                value -= 4;
                result += "IV";
            }else if(value - 3 >= 0)
            {
                value -= 3;
                result += "III";
            }else if (value - 2 >= 0)
            {
                value -= 2;
                result += "II";
            }else if (value - 1 >= 0)
            {
                value -= 1;
                result += 'I';
            }
            counter++;
        }
       
        return result;
    }
}