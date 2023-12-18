using Volo.Abp.Modularity;

namespace HistoricalTrails;

[DependsOn(
    typeof(HistoricalTrailsApplicationModule),
    typeof(HistoricalTrailsDomainTestModule)
    )]
public class HistoricalTrailsApplicationTestModule : AbpModule
{

}
