using valueobj.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace valueobj.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class valueobjController : AbpControllerBase
{
    protected valueobjController()
    {
        LocalizationResource = typeof(valueobjResource);
    }
}
