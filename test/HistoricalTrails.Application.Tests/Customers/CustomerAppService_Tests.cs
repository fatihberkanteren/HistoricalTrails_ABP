using System;
using System.Threading.Tasks;
using HistoricalTrails.Users;
using Shouldly;
using Xunit;

namespace HistoricalTrails.Customers;


public class AuthorAppService_Tests : HistoricalTrailsApplicationTestBase
{
    private readonly ICustomerAppService _authorAppService;

    public AuthorAppService_Tests()
    {
        _authorAppService = GetRequiredService<ICustomerAppService>();
    }

    [Fact]
    public async Task Should_Get_All_Authors_Without_Any_Filter()
    {
        var result = await _authorAppService.GetListAsync(new GetCustomerListDto());

        result.TotalCount.ShouldBeGreaterThanOrEqualTo(2);
        result.Items.ShouldContain(author => author.Name == "George Orwell");
        result.Items.ShouldContain(author => author.Name == "Douglas Adams");
    }

    [Fact]
    public async Task Should_Get_Filtered_Authors()
    {
        var result = await _authorAppService.GetListAsync(
            new GetCustomerListDto { Filter = "George" });

        result.TotalCount.ShouldBeGreaterThanOrEqualTo(1);
        result.Items.ShouldContain(author => author.Name == "George Orwell");
        result.Items.ShouldNotContain(author => author.Name == "Douglas Adams");
    }

    [Fact]
    public async Task Should_Create_A_New_Author()
    {
        var authorDto = await _authorAppService.CreateAsync(
            new CreateCustomerDto
            {
                Name = "Edward Bellamy"
            }
        );

        authorDto.Id.ShouldNotBe(Guid.Empty);
        authorDto.Name.ShouldBe("Edward Bellamy");
    }

    [Fact]
    public async Task Should_Not_Allow_To_Create_Duplicate_Author()
    {
        await Assert.ThrowsAsync<CustomerAlreadyExistsException>(async () =>
        {
            await _authorAppService.CreateAsync(
                new CreateCustomerDto
                {
                    Name = "Douglas Adams"
                }
            );
        });
    }

    //TODO: Test other methods...
}
