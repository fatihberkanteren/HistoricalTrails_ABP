using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HistoricalTrails.Blogs
{
    public class BlogAppService :
        CrudAppService<
        Blog, //The Book entity
        BlogDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBlogDto>, //Used to create/update a book
    IBlogAppService //implement the IBookAppService
    {
        public BlogAppService(IRepository<Blog, Guid> repository)
        : base(repository)
        {

        }
    }
}
