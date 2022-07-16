using Serilog.Wrapper.Unity;
using Unity;

namespace Serilog.Wrapper;

public class ServiceSuite 
    : Config.Wrapper.ServiceSuite
{
    public ServiceSuite(
        IUnityContainer container)
        : base(container)
    {
    }

    protected override void RegisterAppData()
    {
        base.RegisterAppData();
        RegisterSet<AppLoggerSet>();  
    }
}