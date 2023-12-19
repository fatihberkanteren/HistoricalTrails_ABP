using HistoricalTrails.Users;
using System;
using System.ComponentModel.DataAnnotations;

namespace HistoricalTrails.Customers;

public class UpdateCustomerDto
{
    [Required]
    [StringLength(CustomerConsts.MaxNameLength)]
    public string Name { get; set; }
    [Required]
    public string Surname { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public short Age { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public DateTime RegistrationDate { get; set; }
    [Required]
    public string ProfilImageUrl { get; set; }
}
