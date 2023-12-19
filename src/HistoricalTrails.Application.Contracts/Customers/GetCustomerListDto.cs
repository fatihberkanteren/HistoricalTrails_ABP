using Volo.Abp.Application.Dtos;

namespace HistoricalTrails.Customers;

public class GetCustomerListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}
