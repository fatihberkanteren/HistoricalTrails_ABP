using AutoMapper;
using HistoricalTrails.HistoricalPlaces;

namespace HistoricalTrails;
public class HistoricalTrailsApplicationAutoMapperProfile : Profile
{
    public HistoricalTrailsApplicationAutoMapperProfile()
    {
        CreateMap<HistoricalPlace, HistoricalPlaceDto>();
        CreateMap<CreateUpdateHistoricalPlaceDto, HistoricalPlace>();
    }
}
