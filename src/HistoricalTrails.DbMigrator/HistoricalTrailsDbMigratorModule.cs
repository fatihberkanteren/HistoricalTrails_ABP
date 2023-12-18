using HistoricalTrails.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HistoricalTrails.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HistoricalTrailsEntityFrameworkCoreModule),
    typeof(HistoricalTrailsApplicationContractsModule)
    )]
public class HistoricalTrailsDbMigratorModule : AbpModule
{
}
