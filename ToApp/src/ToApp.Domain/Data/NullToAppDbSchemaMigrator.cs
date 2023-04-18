using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ToApp.Data;

/* This is used if database provider does't define
 * IToAppDbSchemaMigrator implementation.
 */
public class NullToAppDbSchemaMigrator : IToAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
