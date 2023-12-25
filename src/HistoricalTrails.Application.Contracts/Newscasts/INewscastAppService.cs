using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HistoricalTrails.Newscasts
{
    public interface INewscastAppService :
        ICrudAppService< //Defines CRUD methods
        NewscastDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateNewscastDto> //Used to create/update a book
    {
    }
}
