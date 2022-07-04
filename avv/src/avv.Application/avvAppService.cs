using System;
using System.Collections.Generic;
using System.Text;
using avv.Localization;
using Volo.Abp.Application.Services;

namespace avv;

/* Inherit your application services from this class.
 */
public abstract class avvAppService : ApplicationService
{
    protected avvAppService()
    {
        LocalizationResource = typeof(avvResource);
    }
}
