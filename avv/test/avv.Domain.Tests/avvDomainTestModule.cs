using avv.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace avv;

[DependsOn(
    typeof(avvEntityFrameworkCoreTestModule)
    )]
public class avvDomainTestModule : AbpModule
{

}
