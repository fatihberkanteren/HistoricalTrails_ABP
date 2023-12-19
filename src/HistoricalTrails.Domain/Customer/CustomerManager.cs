using JetBrains.Annotations;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace HistoricalTrails.Users
{
    public class CustomerManager : DomainService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> CreateAsync(
            [NotNull] string name,
            [NotNull] string surname,
            [NotNull] string username,
            [NotNull] string password,
            [NotNull] string email,
            [CanBeNull] string gender,
            [NotNull] short age,
            [NotNull] string phoneNumber,
            DateTime registrationDate,
            [CanBeNull] string? profilImageUrl = null)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));
            Check.NotNullOrWhiteSpace(phoneNumber, nameof(phoneNumber));

            var existingAuthor = await _customerRepository.FindByNameAsync(name);
            if (existingAuthor != null)
            {
                throw new CustomerAlreadyExistsException(name);
            }

            return new Customer(
                GuidGenerator.Create(),
                name,
                surname,
                username,
                password,
                email,
                gender,
                age,
                phoneNumber,
                registrationDate,
                profilImageUrl
            );
        }

        public async Task ChangeNameAsync(
            [NotNull] Customer user,
            [NotNull] string newName)
        {
            Check.NotNull(user, nameof(user));
            Check.NotNullOrWhiteSpace(newName, nameof(newName));

            var existingAuthor = await _customerRepository.FindByNameAsync(newName);
            if (existingAuthor != null && existingAuthor.Id != user.Id)
            {
                throw new CustomerAlreadyExistsException(newName);
            }

            user.ChangeName(newName);
        }
    }
}
