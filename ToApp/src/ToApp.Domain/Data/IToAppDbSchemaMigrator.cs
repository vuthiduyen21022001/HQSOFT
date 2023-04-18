using System.Threading.Tasks;

namespace ToApp.Data;

public interface IToAppDbSchemaMigrator
{
    Task MigrateAsync();
}
