using System.Threading.Tasks;

namespace HistoricalTrails.Data;

public interface IHistoricalTrailsDbSchemaMigrator
{
    Task MigrateAsync();
}
