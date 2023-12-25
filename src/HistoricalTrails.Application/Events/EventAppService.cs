using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HistoricalTrails.Events
{
    public class EventAppService :
        CrudAppService<
        Event, //The Book entity
        EventDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateEventDto>, //Used to create/update a book
    IEventAppService //implement the IBookAppService
    {
        public EventAppService(IRepository<Event, Guid> repository) : base(repository)
        {
        }
    }
}
