using System;
using System.Collections.Generic;
using System.Text;
using ToApp.Localization;
using Volo.Abp.Application.Services;

namespace ToApp;

/* Inherit your application services from this class.
 */
public abstract class ToAppAppService : ApplicationService
{
    protected ToAppAppService()
    {
        LocalizationResource = typeof(ToAppResource);
    }
}
