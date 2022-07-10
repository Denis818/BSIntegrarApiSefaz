using BSIntegrarApiSefaz.ClienteWeb;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BSIntegrarApiSefaz.Controllers
{
    public class CepController : Controller
    {
        private readonly ViaCep _viaCep;

        public CepController(ViaCep viaCep)
        {
            _viaCep = viaCep;
        }

        [HttpGet("GetCep")]
        public async Task<IActionResult> GetCep(string cep)
        {
            var resultCep = await _viaCep.GetCep(cep);

            return Ok(resultCep);
        }
    }
}
