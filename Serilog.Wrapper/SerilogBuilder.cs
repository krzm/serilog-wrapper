namespace Serilog.Wrapper;

public class SerilogBuilder 
    : ISerilogBuilder
{
    public ILogger BuildLog()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        return Log.Logger;     
    }
}