using Volo.Abp.Modularity;

namespace TestUI
{
    [DependsOn(
        typeof(TestUIApplicationModule),
        typeof(TestUIDomainTestModule)
        )]
    public class TestUIApplicationTestModule : AbpModule
    {

    }
}