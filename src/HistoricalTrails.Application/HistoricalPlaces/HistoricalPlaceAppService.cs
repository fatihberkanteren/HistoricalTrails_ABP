using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HistoricalTrails.HistoricalPlaces
{
    public class HistoricalPlaceAppService : CrudAppService<
        HistoricalPlace, //The HistoricalPlace entity
        HistoricalPlaceDto, //Used to show HistoricalPlaces
        Guid, //Primary key of the HistoricalPlace entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateHistoricalPlaceDto>, //Used to create/update a HistoricalPlace
    IHistoricalPlaceAppService //implement the IHistoricalPlaceAppService
    {
        public HistoricalPlaceAppService(IRepository<HistoricalPlace, Guid> repository) : base(repository)
        {
        }
    }
}
