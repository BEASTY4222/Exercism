// TODO: define the 'LogLevel' enum
enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string log = logLine.Substring(1,3);
        switch (log)
        {
            case "TRC": return LogLevel.Trace;
            case "DBG": return LogLevel.Debug;
            case "INF": return LogLevel.Info;
            case "WRN": return LogLevel.Warning;
            case "ERR": return LogLevel.Error;
            case "FTL": return LogLevel.Fatal;
            default   :return LogLevel.Unknown;
        }
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        int num = 0;
        switch (logLevel)
        {
            case LogLevel.Trace  : num = 1; break;
            case LogLevel.Debug  : num = 2; break;
            case LogLevel.Info   : num = 4; break;
            case LogLevel.Warning: num = 5; break;
            case LogLevel.Error  : num = 6; break;
            case LogLevel.Fatal  : num = 42; break;
            default              :num = 0; break;
        }
        return num + ":" + message;
    }
}
