using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HistoricalTrails.Newscasts
{
    public class NewscastAppService :
        CrudAppService<
        Newscast, //The Book entity
        NewscastDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateNewscastDto>, //Used to create/update a book
    INewscastAppService //implement the IBookAppService
    {
        public NewscastAppService(IRepository<Newscast, Guid> repository) : base(repository)
        {
        }
    }
}
