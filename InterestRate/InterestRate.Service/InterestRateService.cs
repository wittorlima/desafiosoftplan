using InterestRate.Domain.Interfaces.Services;

namespace InterestRate.Domain.Service
{
    public class InterestRateService : IInterestRateService
    {
        public Domain.Entities.InterestRate Get() => new Domain.Entities.InterestRate() { InterestRateAmount = 0.01m};
    }
}
