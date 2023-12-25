using System;
using System.Threading.Tasks;
using HistoricalTrails.HistoricalPlaces;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using HistoricalTrails.Web.Pages;

namespace HistoricalTrails.Web.Pages.HistoricalPlaces;

public class EditModalModel : HistoricalTrailsPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateUpdateHistoricalPlaceDto HistoricalPlace { get; set; }

    private readonly IHistoricalPlacesAppService _historicalPlaceAppService;

    public EditModalModel(IHistoricalPlacesAppService historicalPlaceAppService)
    {
        _historicalPlaceAppService = historicalPlaceAppService;
    }

    public async Task OnGetAsync()
    {
        var historicalPlace = await _historicalPlaceAppService.GetAsync(Id);
        HistoricalPlace = ObjectMapper.Map<HistoricalPlaceDto, CreateUpdateHistoricalPlaceDto>(historicalPlace);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _historicalPlaceAppService.UpdateAsync(Id, HistoricalPlace);
        return NoContent();
    }
}
