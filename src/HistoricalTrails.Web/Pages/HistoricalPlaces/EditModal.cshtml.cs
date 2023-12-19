using HistoricalTrails.HistoricalPlaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace HistoricalTrails.Web.Pages.HistoricalPlaces
{
    public class EditModalModel : HistoricalTrailsPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateHistoricalPlaceDto HistoricalPlace { get; set; }

        private readonly IHistoricalTrailsAppService _historicalPlaceAppService;

        public EditModalModel(IHistoricalTrailsAppService historicalPlaceAppService)
        {
            _historicalPlaceAppService = historicalPlaceAppService;
        }
        public async Task OnGetAsync()
        {
            var historicalPlaceDto = await _historicalPlaceAppService.GetAsync(Id);
            HistoricalPlace = ObjectMapper.Map<HistoricalPlaceDto, CreateUpdateHistoricalPlaceDto>(historicalPlaceDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _historicalPlaceAppService.UpdateAsync(Id, HistoricalPlace);
            return NoContent();
        }

        public void OnGet()
        {
        }
    }
}
