using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HistoricalTrails.Blogs
{
    public interface IBlogAppService :
        ICrudAppService< //Defines CRUD methods
        BlogDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBlogDto> //Used to create/update a book
    {
    }
}
