using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ToApp.Blazor;

[Dependency(ReplaceServices = true)]
public class ToAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ToApp";
}
