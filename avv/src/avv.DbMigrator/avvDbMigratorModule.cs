using avv.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace avv.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(avvEntityFrameworkCoreModule),
    typeof(avvApplicationContractsModule)
    )]
public class avvDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
