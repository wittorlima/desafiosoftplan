using CalculatesInterest.Domain.Entities;
using CalculatesInterest.Domain.Interfaces.Repository;
using CalculatesInterest.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace CalculatesInterest.Domain.Service
{
    public class InterestRateService : IInterestRateService
    {
        private readonly IInterestRateRepository _interestRateRepository;
        public InterestRateService(IInterestRateRepository interestRateRepository)
        {
            _interestRateRepository = interestRateRepository;
        }

        public Task<InterestRate> Get() => _interestRateRepository.Get();
    }
}
