using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace HistoricalTrails.Pages;

public class Index_Tests : HistoricalTrailsWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
