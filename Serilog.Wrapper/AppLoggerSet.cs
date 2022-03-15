using DIHelper.Unity;
using Unity;

namespace Serilog.Wrapper;

public class AppLoggerSet 
    : UnityDependencySet
{
    public AppLoggerSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<ISerilogBuilder, SerilogBuilder>();
        Container.RegisterInstance(
            Container.Resolve<ISerilogBuilder>()
                .BuildLog());
    }
}