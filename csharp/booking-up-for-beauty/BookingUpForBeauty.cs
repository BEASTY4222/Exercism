static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if(appointmentDate > DateTime.Now) return false;
        return true;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if(appointmentDate.Hour >= 12 && appointmentDate.Hour < 18) return true;
        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate:M/d/yyyy h:mm:ss tt}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(2026, 9, 15, 0, 0, 0);
    }
}
