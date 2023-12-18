using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HistoricalTrails.Data;

/* This is used if database provider does't define
 * IHistoricalTrailsDbSchemaMigrator implementation.
 */
public class NullHistoricalTrailsDbSchemaMigrator : IHistoricalTrailsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
