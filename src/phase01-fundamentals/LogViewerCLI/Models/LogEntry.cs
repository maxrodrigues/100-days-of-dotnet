namespace LogViewerCLI.Models;

public enum LogLevel
{
    Info,
    Warning,
    Error,
    Critical,
    Unknown
}

public record LogEntry(DateTime Timestamp, LogLevel Level, string Message)
{
    public string RawContent { get; init; } = string.Empty;
}