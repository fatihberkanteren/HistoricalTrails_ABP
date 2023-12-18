using System;
using System.Collections.Generic;
using System.Text;
using HistoricalTrails.Localization;
using Volo.Abp.Application.Services;

namespace HistoricalTrails;

/* Inherit your application services from this class.
 */
public abstract class HistoricalTrailsAppService : ApplicationService
{
    protected HistoricalTrailsAppService()
    {
        LocalizationResource = typeof(HistoricalTrailsResource);
    }
}
