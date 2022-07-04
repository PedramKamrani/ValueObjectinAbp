using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace avv.Web;

[Dependency(ReplaceServices = true)]
public class avvBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "avv";
}
