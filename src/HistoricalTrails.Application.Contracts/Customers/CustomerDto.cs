using System;
using Volo.Abp.Application.Dtos;

namespace HistoricalTrails.Customers;

public class CustomerDto : EntityDto<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public short Age { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string ProfilImageUrl { get; set; }
}
