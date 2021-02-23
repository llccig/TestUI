using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TestUI.EntityFrameworkCore
{
    [DependsOn(
        typeof(TestUIEntityFrameworkCoreModule)
        )]
    public class TestUIEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TestUIMigrationsDbContext>();
        }
    }
}
