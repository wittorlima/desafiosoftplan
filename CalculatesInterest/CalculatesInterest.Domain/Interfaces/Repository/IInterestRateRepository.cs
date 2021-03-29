using CalculatesInterest.Domain.Entities;
using System.Threading.Tasks;

namespace CalculatesInterest.Domain.Interfaces.Repository
{
    public interface IInterestRateRepository
    {
        Task<InterestRate> Get();
    }
}
