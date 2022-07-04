using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using valueobj.Data;
using Volo.Abp.DependencyInjection;

namespace valueobj.EntityFrameworkCore;

public class EntityFrameworkCorevalueobjDbSchemaMigrator
    : IvalueobjDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorevalueobjDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the valueobjDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<valueobjDbContext>()
            .Database
            .MigrateAsync();
    }
}
