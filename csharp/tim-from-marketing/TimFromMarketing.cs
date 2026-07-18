static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string? result;

        if (id == null && department != null) result = name +" - "+ department.ToUpper();
        else if (id == null && department == null) result = name +" - OWNER";
        else if(id != null && department == null) result =  "["+ id +"] - "+ name +" - OWNER";
        else result = "["+ id +"] - "+ name +" - "+ department.ToUpper();
        
        return result;
    }
}
