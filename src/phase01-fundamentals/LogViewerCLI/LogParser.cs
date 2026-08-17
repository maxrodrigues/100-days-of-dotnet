using LogViewerCLI.Models;

namespace LogViewerCLI;

public static class LogParser
{
    public static LogEntry ParseLine(string line)
    {
        var parts = line.Split('|');
        if (parts.Length < 3)
        {
            return new LogEntry(DateTime.Now, LogLevel.Unknown, line)
            {
                RawContent = line
            };
        }

        var timestamp = DateTime.TryParse(parts[0], out var parsedDate) ? parsedDate : DateTime.Now;
        var level = ParseLogLevel(parts[1]);
        var message = parts[2];

        return new LogEntry(timestamp, level, message)
        {
            RawContent = line
        };
    }

    private static LogLevel ParseLogLevel(string logLine) => logLine.Trim().ToUpper() switch
    {
        "INFO" or "INFORMATION" => LogLevel.Info,
        "WARN" or "WARNING" => LogLevel.Warning,
        "ERR" or "ERROR" => LogLevel.Error,
        "FATAL" or "CRITICAL" => LogLevel.Critical,
        _ => LogLevel.Unknown
    };

    public static string FormatLogOutput(LogEntry entry) => entry switch
    {
        { Level: LogLevel.Error or LogLevel.Critical } log => $"🚨 [{log.Timestamp:HH:mm:ss}] FALHA GRAVE: {log.Message}",
        { Level: LogLevel.Warning } log => $"⚠️ [{log.Timestamp:HH:mm:ss}] ATENÇÃO: {log.Message}",
        { Level: LogLevel.Info } log => $"ℹ️ [{log.Timestamp:HH:mm:ss}] INFO: {log.Message}",
        _ => $"❓ [{entry.Timestamp:HH:mm:ss}] LOG: {entry.Message}"
    };
}