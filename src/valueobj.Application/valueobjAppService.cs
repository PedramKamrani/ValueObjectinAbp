using System;
using System.Collections.Generic;
using System.Text;
using valueobj.Localization;
using Volo.Abp.Application.Services;

namespace valueobj;

/* Inherit your application services from this class.
 */
public abstract class valueobjAppService : ApplicationService
{
    protected valueobjAppService()
    {
        LocalizationResource = typeof(valueobjResource);
    }
}
