using JetBrains.Annotations;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace HistoricalTrails.Users
{
    public class Customer : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public byte Gender { get; set; }
        public short Age { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string ProfilImageUrl { get; set; }
        private Customer()
        {
            
        }

        internal Customer(
        Guid id,
        [NotNull] string name,
        [NotNull] string surname,
        [NotNull] string username,
        [NotNull] string password,
        [NotNull] string email,
        [NotNull] byte gender,
        [NotNull] short age,
        [NotNull] string phoneNumber,
        DateTime registrationDate,
        [NotNull] string profilImageUrl)
        : base(id)
        {
            SetName(name);
            Surname = surname;
            Username = username;
            Password = password;
            Email = email;
            Gender = gender;
            Age = age;
            PhoneNumber = phoneNumber;
            RegistrationDate = registrationDate;
            ProfilImageUrl = profilImageUrl;
        }

        internal Customer ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }

        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength: CustomerConsts.MaxNameLength
            );
        }
    }
}
