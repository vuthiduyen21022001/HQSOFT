using Volo.Abp.Modularity;

namespace ToApp;

[DependsOn(
    typeof(ToAppApplicationModule),
    typeof(ToAppDomainTestModule)
    )]
public class ToAppApplicationTestModule : AbpModule
{

}
