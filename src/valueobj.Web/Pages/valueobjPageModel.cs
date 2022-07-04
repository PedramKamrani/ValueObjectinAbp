using valueobj.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace valueobj.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class valueobjPageModel : AbpPageModel
{
    protected valueobjPageModel()
    {
        LocalizationResourceType = typeof(valueobjResource);
    }
}
