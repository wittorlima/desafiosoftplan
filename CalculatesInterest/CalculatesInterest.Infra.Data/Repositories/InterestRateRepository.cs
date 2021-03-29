using CalculatesInterest.Domain.Entities;
using CalculatesInterest.Domain.Exceptions;
using CalculatesInterest.Domain.Interfaces.Repository;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculatesInterest.Infra.Data.Repositories
{
    public class InterestRateRepository : IInterestRateRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _endPoint= "taxajuros";
        public InterestRateRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<InterestRate> Get()
        {
            try
            {
                var response = await _httpClient.GetStringAsync($"{_httpClient.BaseAddress}{_endPoint}");
                var interestRate = JsonConvert.DeserializeObject<InterestRate>(response);
                return interestRate;
            }
            catch 
            {
                throw new ServiceUnavailableException("Service Interest Rate Unavailable");
            }
        }
    }
}
