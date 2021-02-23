using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestUI.Data;
using Volo.Abp.DependencyInjection;

namespace TestUI.EntityFrameworkCore
{
    public class EntityFrameworkCoreTestUIDbSchemaMigrator
        : ITestUIDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTestUIDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TestUIMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TestUIMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}