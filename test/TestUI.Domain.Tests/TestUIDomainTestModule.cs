using TestUI.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TestUI
{
    [DependsOn(
        typeof(TestUIEntityFrameworkCoreTestModule)
        )]
    public class TestUIDomainTestModule : AbpModule
    {

    }
}