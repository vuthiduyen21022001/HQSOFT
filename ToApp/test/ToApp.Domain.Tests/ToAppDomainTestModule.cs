using ToApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ToApp;

[DependsOn(
    typeof(ToAppEntityFrameworkCoreTestModule)
    )]
public class ToAppDomainTestModule : AbpModule
{

}
