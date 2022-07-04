using Volo.Abp.Modularity;

namespace valueobj;

[DependsOn(
    typeof(valueobjApplicationModule),
    typeof(valueobjDomainTestModule)
    )]
public class valueobjApplicationTestModule : AbpModule
{

}
