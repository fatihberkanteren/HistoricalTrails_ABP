using AutoMapper;
using HistoricalTrails.Customers;
using HistoricalTrails.HistoricalPlaces;
using HistoricalTrails.Users;

namespace HistoricalTrails;

public class HistoricalTrailsApplicationAutoMapperProfile : Profile
{
    public HistoricalTrailsApplicationAutoMapperProfile()
    {
        CreateMap<HistoricalPlace, HistoricalPlaceDto>();
        CreateMap<CreateUpdateHistoricalPlaceDto, HistoricalPlace>();
        CreateMap<Customer, CustomerDto>();
    }
}
