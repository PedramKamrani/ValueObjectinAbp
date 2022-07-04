using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace valueobj.Web;

[Dependency(ReplaceServices = true)]
public class valueobjBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "valueobj";
}
