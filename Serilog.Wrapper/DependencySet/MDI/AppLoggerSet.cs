using DIHelper.MicrosoftDI;
using Microsoft.Extensions.DependencyInjection;

namespace Serilog.Wrapper.MDI;

public class AppLoggerSet 
	: MDIDependencySet
{
	public AppLoggerSet(
		IServiceCollection container)
		: base(container)
	{
	}

	public override void Register()
	{
		Container.AddSingleton<ISerilogBuilder, SerilogBuilder>();
		var loggerBuilder = Container
			.BuildServiceProvider()
			.GetService<ISerilogBuilder>();
		ArgumentNullException.ThrowIfNull(loggerBuilder);
		var logger = loggerBuilder.BuildLog();
        Container.AddSingleton(logger);
	}
}