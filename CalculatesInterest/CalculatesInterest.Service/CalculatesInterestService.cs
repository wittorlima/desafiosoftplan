using CalculatesInterest.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace CalculatesInterest.Domain.Service
{
    public class CalculatesInterestService : ICalculatesInterestService
    {
        private readonly IInterestRateService _interestRateService;
        public CalculatesInterestService(IInterestRateService interestRateService)
        {
            _interestRateService = interestRateService;
        }

        public async Task<string> CalculatesInterest(double initialValue, int months)
        {
            var rate = await _interestRateService.Get();
            var interestRate = GetInterestRate(rate, initialValue);
            var result = initialValue * Math.Pow(1 + interestRate / 100, months);
            return $"{result:F2}";
        }

        private double GetInterestRate(Entities.InterestRate rate, double initialValue) => rate.InterestRateAmount * initialValue;
        
    }
}
