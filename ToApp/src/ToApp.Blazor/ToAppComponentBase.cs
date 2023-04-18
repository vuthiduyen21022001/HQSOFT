using ToApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ToApp.Blazor;

public abstract class ToAppComponentBase : AbpComponentBase
{
    protected ToAppComponentBase()
    {
        LocalizationResource = typeof(ToAppResource);
    }
}
