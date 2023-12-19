
using HistoricalTrails.Permissions;
using HistoricalTrails.Users;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace HistoricalTrails.Customers;

[Authorize(HistoricalTrailsPermissions.Customers.Default)]
public class CustomerAppService : HistoricalTrailsAppService, ICustomerAppService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly CustomerManager _customerManager;

    public CustomerAppService(
        ICustomerRepository customerRepository,
        CustomerManager customerManager)
    {
        _customerRepository = customerRepository;
        _customerManager = customerManager;
    }

    public async Task<CustomerDto> GetAsync(Guid id)
    {
        var customer = await _customerRepository.GetAsync(id);
        return ObjectMapper.Map<Customer, CustomerDto>(customer);
    }
    public async Task<PagedResultDto<CustomerDto>> GetListAsync(GetCustomerListDto input)
    {
        if (input.Sorting.IsNullOrWhiteSpace())
        {
            input.Sorting = nameof(Customer.Name);
        }

        var customers = await _customerRepository.GetListAsync(
            input.SkipCount,
            input.MaxResultCount,
            input.Sorting,
            input.Filter
        );

        var totalCount = input.Filter == null
            ? await _customerRepository.CountAsync()
            : await _customerRepository.CountAsync(
                customer => customer.Name.Contains(input.Filter));

        return new PagedResultDto<CustomerDto>(
            totalCount,
            ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers)
        );
    }
    [Authorize(HistoricalTrailsPermissions.Customers.Create)]
    public async Task<CustomerDto> CreateAsync(CreateCustomerDto input)
    {
        var customer = await _customerManager.CreateAsync(
            input.Name,
            input.Surname,
            input.Username,
            input.Password,
            input.Email,
            input.Gender,
            input.Age,
            input.PhoneNumber,
            input.RegistrationDate,
            input.ProfilImageUrl
        );

        await _customerRepository.InsertAsync(customer);
        return ObjectMapper.Map<Customer, CustomerDto>(customer);
    }

    [Authorize(HistoricalTrailsPermissions.Customers.Edit)]
    public async Task UpdateAsync(Guid id, UpdateCustomerDto input)
    {
        var customer = await _customerRepository.GetAsync(id);

        if (customer.Name != input.Name)
        {
            await _customerManager.ChangeNameAsync(customer, input.Name);
        }

        customer.Name = input.Name;
        customer.Surname = input.Surname;
        customer.Username = input.Username;
        customer.Password = input.Password;
        customer.Email = input.Email;
        customer.Gender = input.Gender;
        customer.Age = input.Age;
        customer.PhoneNumber = input.PhoneNumber;
        customer.RegistrationDate = input.RegistrationDate;
        customer.ProfilImageUrl = input.ProfilImageUrl;

        await _customerRepository.UpdateAsync(customer);
    }

    [Authorize(HistoricalTrailsPermissions.Customers.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _customerRepository.DeleteAsync(id);
    }

}
