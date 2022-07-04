using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace valueobj.Data;

/* This is used if database provider does't define
 * IvalueobjDbSchemaMigrator implementation.
 */
public class NullvalueobjDbSchemaMigrator : IvalueobjDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
