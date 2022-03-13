using CLIHelper;
using Serilog.Events;

namespace Serilog.Wrapper;

public class LoggerMock 
    : OutMock
    , ILogger
{
    public void Write(LogEvent logEvent)
    {
        Buffer.AppendLine(logEvent.RenderMessage());
    }
}