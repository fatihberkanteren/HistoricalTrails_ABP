using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using HistoricalTrails.Customers;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using HistoricalTrails.Users;

namespace HistoricalTrails.Web.Pages.Customers;

public class CreateModalModel : HistoricalTrailsPageModel
{
    [BindProperty]
    public CreateCustomerViewModel Customer { get; set; }

    private readonly ICustomerAppService _customerAppService;

    public CreateModalModel(ICustomerAppService customerAppService)
    {
        _customerAppService = customerAppService;
    }

    public void OnGet()
    {
        Customer = new CreateCustomerViewModel();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateCustomerViewModel, CreateCustomerDto>(Customer);
        await _customerAppService.CreateAsync(dto);
        return NoContent();
    }

    public class CreateCustomerViewModel
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
}
