using CalculatesInterest.Domain.Exceptions;
using CalculatesInterest.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CalculatesInterest.API.Controllers
{
    [Route("calculajuros")]
    [ApiController]
    public class CalculatesInterestController : Controller
    {
        private readonly ICalculatesInterestService _calculatesInterestService;
        public CalculatesInterestController(ICalculatesInterestService calculatesInterestService)
        {
            _calculatesInterestService = calculatesInterestService;
        }

        /// <summary>
        /// Calcula Juros
        /// </summary>
        /// <param name="initialValue">Valor Inicial</param>
        /// <param name="months">Meses</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> CalculatesInterest([FromQuery(Name = "valorInicial")] double initialValue, [FromQuery(Name = "meses")] int months)
        {
            try
            {
                return Ok(await _calculatesInterestService.CalculatesInterest(initialValue, months));
            }
            catch (Exception exception)
            {
                if (exception is ServiceUnavailableException)
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable, exception.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
