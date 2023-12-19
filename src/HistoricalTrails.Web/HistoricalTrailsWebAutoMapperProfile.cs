using AutoMapper;
using HistoricalTrails.HistoricalPlaces;

namespace HistoricalTrails.Web;

public class HistoricalTrailsWebAutoMapperProfile : Profile
{
    public HistoricalTrailsWebAutoMapperProfile()
    {
        CreateMap<HistoricalPlaceDto, CreateUpdateHistoricalPlaceDto>();
    }
}
