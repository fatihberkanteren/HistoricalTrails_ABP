using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HistoricalTrails.HistoricalPlaces
{
    public interface IHistoricalTrailsAppService : ICrudAppService< //Defines CRUD methods
        HistoricalPlaceDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateHistoricalPlaceDto> //Used to create/update a book

    {
    }
}
