#nullable enable
namespace TheOne.Logging
{
    public sealed class LogConfig
    {
        public LogLevel Level { get; set; } = LogLevel.Info;
    }

    public enum LogLevel
    {
        Debug,
        Info,
        Warning,
        Error,
        Critical,
        Exception,
        None,
    }
}