using avv.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace avv.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class avvController : AbpControllerBase
{
    protected avvController()
    {
        LocalizationResource = typeof(avvResource);
    }
}
