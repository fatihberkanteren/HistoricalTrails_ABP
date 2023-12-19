using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace HistoricalTrails.HistoricalPlaces
{
    public class HistoricalPlaceAppService_Test : HistoricalTrailsApplicationTestBase
    {
        private readonly IHistoricalTrailsAppService _historicalPlaceAppService;

        public HistoricalPlaceAppService_Test()
        {
            _historicalPlaceAppService = GetRequiredService<IHistoricalTrailsAppService>();
        }

        [Fact]
        public async Task Should_Create_A_Valid_HistoricalPlace()
        {
            //Act
            var result = await _historicalPlaceAppService.CreateAsync(
                new CreateUpdateHistoricalPlaceDto
                {
                    Name = "Ani Arkeolojik Alanı",
                    Description = "Açıklama",
                    History = "Tarihi",
                    ImageUrl = "ImageUrl"
                }
            );

            //Assert
            result.Id.ShouldNotBe(Guid.Empty);
            result.Name.ShouldBe("Ani Arkeolojik Alanı");
        }

    }
}
