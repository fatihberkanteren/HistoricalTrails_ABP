using AutoMapper;
using HistoricalTrails.Customers;
using HistoricalTrails.HistoricalPlaces;

namespace HistoricalTrails.Web;

public class HistoricalTrailsWebAutoMapperProfile : Profile
{
    public HistoricalTrailsWebAutoMapperProfile()
    {
        CreateMap<HistoricalPlaceDto, CreateUpdateHistoricalPlaceDto>();
        CreateMap<Pages.Customers.CreateModalModel.CreateCustomerViewModel,CreateCustomerDto>();
    }
}
