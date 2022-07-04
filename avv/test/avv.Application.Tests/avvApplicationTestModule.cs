using Volo.Abp.Modularity;

namespace avv;

[DependsOn(
    typeof(avvApplicationModule),
    typeof(avvDomainTestModule)
    )]
public class avvApplicationTestModule : AbpModule
{

}
