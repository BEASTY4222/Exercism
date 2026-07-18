public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        return shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing" ,
            _ => "UNKNOWN"
        };
    }

    public static string AnalyzeOffField(object report)
    {
        
        if(report is int a) 
            return $"There are {a} supporters at the match.";
        if(report is string b)
            return b;

        switch (report.GetType().ToString())
        {   
            case "Foul"    : return "The referee deemed a foul.";
            case "Incident": 
                Incident incident = (Incident)report;
                return incident.GetDescription();
            case "Injury"  : 
                Injury injury = (Injury)report;
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
            case "Manager" : 
                Manager manager = (Manager)report;
                string result = manager.Name;
                if(manager?.Club != null) result += $" ({manager.Club})";
                return result;
        }
        return "";
    }
}
