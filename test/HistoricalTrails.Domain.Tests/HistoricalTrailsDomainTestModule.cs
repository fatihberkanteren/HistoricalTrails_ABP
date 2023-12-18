using HistoricalTrails.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HistoricalTrails;

[DependsOn(
    typeof(HistoricalTrailsEntityFrameworkCoreTestModule)
    )]
public class HistoricalTrailsDomainTestModule : AbpModule
{

}
