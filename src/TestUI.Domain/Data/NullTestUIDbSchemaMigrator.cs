using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TestUI.Data
{
    /* This is used if database provider does't define
     * ITestUIDbSchemaMigrator implementation.
     */
    public class NullTestUIDbSchemaMigrator : ITestUIDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}