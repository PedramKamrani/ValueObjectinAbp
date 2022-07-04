using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace avv.Data;

/* This is used if database provider does't define
 * IavvDbSchemaMigrator implementation.
 */
public class NullavvDbSchemaMigrator : IavvDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
