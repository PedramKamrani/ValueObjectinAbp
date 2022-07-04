using valueobj.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace valueobj.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(valueobjEntityFrameworkCoreModule),
    typeof(valueobjApplicationContractsModule)
    )]
public class valueobjDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
