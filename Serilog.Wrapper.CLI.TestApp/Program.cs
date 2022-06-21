using Serilog.Wrapper;

ISerilogBuilder logBuilder = new SerilogBuilder();
var log = logBuilder.BuildLog().ForContext<Program>();
log.Information("Hello, this is CLI script, testing Serilog");
log.Information("If you read this in console and in file, it works.");