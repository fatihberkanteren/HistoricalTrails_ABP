using HistoricalTrails.HistoricalPlaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace HistoricalTrails.Web.Pages.HistoricalPlaces
{
    public class CreateModalModel : HistoricalTrailsPageModel
    {      
        public CreateUpdateHistoricalPlaceDto HistoricalPlace { get; set; }
        private readonly IHistoricalTrailsAppService _historicalPlaceAppService;
        public CreateModalModel(IHistoricalTrailsAppService historicalPlaceAppService)
        {
            _historicalPlaceAppService = historicalPlaceAppService;
        }
        public void OnGet()
        {
            HistoricalPlace = new CreateUpdateHistoricalPlaceDto();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _historicalPlaceAppService.CreateAsync(HistoricalPlace);
            return NoContent();
        }
    }
}
