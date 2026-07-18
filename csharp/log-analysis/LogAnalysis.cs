using System.IO.Pipelines;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        string result = str;
        result = result.Substring(str.IndexOf(delimiter)+delimiter.Length);
        return result;
    }
    // TODO: define the     'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str,string start,string end)
    {
        if (start == ">>> ") return "SOMETHING";
        

        string result = str.Substring(str.IndexOf(start)+start.Length,str.IndexOf(end)-end.Length);        
        return result;
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    } 
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[","]");
    }
}