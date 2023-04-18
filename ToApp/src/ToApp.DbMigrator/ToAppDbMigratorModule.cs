using ToApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ToApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ToAppEntityFrameworkCoreModule),
    typeof(ToAppApplicationContractsModule)
    )]
public class ToAppDbMigratorModule : AbpModule
{

}
