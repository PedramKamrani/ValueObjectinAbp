using valueobj.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace valueobj;

[DependsOn(
    typeof(valueobjEntityFrameworkCoreTestModule)
    )]
public class valueobjDomainTestModule : AbpModule
{

}
