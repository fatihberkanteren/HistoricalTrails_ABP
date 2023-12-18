using HistoricalTrails.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HistoricalTrails.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HistoricalTrailsController : AbpControllerBase
{
    protected HistoricalTrailsController()
    {
        LocalizationResource = typeof(HistoricalTrailsResource);
    }
}
