using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HistoricalTrails.Events
{
    public interface IEventAppService :
        ICrudAppService< //Defines CRUD methods
        EventDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateEventDto> //Used to create/update a book
    {
    }
}
