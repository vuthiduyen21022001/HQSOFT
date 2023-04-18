using ToApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ToApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ToAppController : AbpControllerBase
{
    protected ToAppController()
    {
        LocalizationResource = typeof(ToAppResource);
    }
}
