using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ToApp;

[Dependency(ReplaceServices = true)]
public class ToAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ToApp";
}
