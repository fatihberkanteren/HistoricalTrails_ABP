using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace HistoricalTrails.Web;

[Dependency(ReplaceServices = true)]
public class HistoricalTrailsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HistoricalTrails";
}
