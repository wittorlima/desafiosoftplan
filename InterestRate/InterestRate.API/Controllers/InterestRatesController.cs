using InterestRate.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterestRate.API.Controllers
{
    [Route("taxaJuros")]
    [ApiController]
    public class InterestRatesController : Controller
    {
        private readonly IInterestRateService InterestRateService;
        public InterestRatesController(IInterestRateService interestRateService)
        {
            InterestRateService = interestRateService;
        }

        /// <summary>
        /// Obter a taxa de juros
        /// </summary>
        [HttpGet]
        public Domain.Entities.InterestRate Get() => InterestRateService.Get();
    }
}
