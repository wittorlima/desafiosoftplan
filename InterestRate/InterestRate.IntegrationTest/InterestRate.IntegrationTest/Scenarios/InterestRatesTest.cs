using FluentAssertions;
using InterestRate.IntegrationTest.Fixtures;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace InterestRate.IntegrationTest.Scenarios
{
    public class InterestRatesTest
    {
        private readonly TestContext _testContext;
        public InterestRatesTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task GetInterestRateReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/taxaJuros");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
