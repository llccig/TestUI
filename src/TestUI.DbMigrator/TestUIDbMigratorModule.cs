using TestUI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TestUI.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TestUIEntityFrameworkCoreDbMigrationsModule),
        typeof(TestUIApplicationContractsModule)
        )]
    public class TestUIDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
