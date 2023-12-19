﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using HistoricalTrails.EntityFrameworkCore;
using HistoricalTrails.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace HistoricalTrails.Customers;

public class EfCoreCustomerRepository
    : EfCoreRepository<HistoricalTrailsDbContext, Customer, Guid>,
        ICustomerRepository
{
    public EfCoreCustomerRepository(
        IDbContextProvider<HistoricalTrailsDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }

    public async Task<Customer> FindByNameAsync(string name)
    {
        var dbSet = await GetDbSetAsync();
        return await dbSet.FirstOrDefaultAsync(customer => customer.Name == name);
    }

    public async Task<List<Customer>> GetListAsync(
        int skipCount,
        int maxResultCount,
        string sorting,
        string filter = null)
    {
        var dbSet = await GetDbSetAsync();
        return await dbSet
            .WhereIf(
                !filter.IsNullOrWhiteSpace(),
                author => author.Name.Contains(filter)
                )
            .OrderBy(sorting)
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();
    }
}
