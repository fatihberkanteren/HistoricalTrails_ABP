using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace HistoricalTrails.Users
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
        Task<Customer> FindByNameAsync(string name);

        Task<List<Customer>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}
