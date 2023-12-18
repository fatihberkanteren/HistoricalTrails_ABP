using HistoricalTrails.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HistoricalTrails.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class HistoricalTrailsPageModel : AbpPageModel
{
    protected HistoricalTrailsPageModel()
    {
        LocalizationResourceType = typeof(HistoricalTrailsResource);
    }
}
