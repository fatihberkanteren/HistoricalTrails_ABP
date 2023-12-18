using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HistoricalTrails.Data;
using Volo.Abp.DependencyInjection;

namespace HistoricalTrails.EntityFrameworkCore;

public class EntityFrameworkCoreHistoricalTrailsDbSchemaMigrator
    : IHistoricalTrailsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHistoricalTrailsDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the HistoricalTrailsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HistoricalTrailsDbContext>()
            .Database
            .MigrateAsync();
    }
}
