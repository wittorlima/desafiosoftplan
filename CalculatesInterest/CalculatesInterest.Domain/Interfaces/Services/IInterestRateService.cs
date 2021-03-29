using CalculatesInterest.Domain.Entities;
using System.Threading.Tasks;

namespace CalculatesInterest.Domain.Interfaces.Services
{
    public interface IInterestRateService
    {
        Task<InterestRate> Get();
    }
}
