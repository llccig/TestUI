using System.Threading.Tasks;

namespace TestUI.Data
{
    public interface ITestUIDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
