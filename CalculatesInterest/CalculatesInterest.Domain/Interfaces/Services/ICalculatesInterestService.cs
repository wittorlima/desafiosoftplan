using System.Threading.Tasks;

namespace CalculatesInterest.Domain.Interfaces.Services
{
    public interface ICalculatesInterestService
    {
        Task<string> CalculatesInterest(double initialValue, int months);
    }
}
