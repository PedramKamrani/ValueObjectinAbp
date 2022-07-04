using avv.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace avv.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class avvPageModel : AbpPageModel
{
    protected avvPageModel()
    {
        LocalizationResourceType = typeof(avvResource);
    }
}
