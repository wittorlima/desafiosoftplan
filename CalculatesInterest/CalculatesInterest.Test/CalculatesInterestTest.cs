using CalculatesInterest.Domain.Entities;
using CalculatesInterest.Domain.Interfaces.Services;
using CalculatesInterest.Domain.Service;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace CalculatesInterest.Test
{
    public class CalculatesInterestTest
    {
        private Mock<IInterestRateService> _interestRateServiceMock;
        private ICalculatesInterestService _calculatesInterestService;

        public CalculatesInterestTest()
        {
            SetupTest();
        }

        [Fact]
        public void CalculatesInterestValidadeResultTest()
        {
            var result = _calculatesInterestService.CalculatesInterest(100, 5).Result;
            Assert.Equal("105,10", result);
        }

        private Task<InterestRate> GetInterestRate()
        {
            var t = Task.Run(() =>
            {
                return new InterestRate() { InterestRateAmount = 0.01 }; ;
            });
            return t;
        }

        private void SetupTest()
        {
            _interestRateServiceMock = new Mock<IInterestRateService>();
            _interestRateServiceMock.Setup(x => x.Get()).Returns(GetInterestRate());
            _calculatesInterestService = new CalculatesInterestService(_interestRateServiceMock.Object);
        }
    }
}
