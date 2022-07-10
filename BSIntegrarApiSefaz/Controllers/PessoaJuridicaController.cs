using BSIntegrarApiSefaz.ClienteWeb;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BSIntegrarApiSefaz.Controllers
{
    [Route("Home")]
    public class PessoaJuridicaController : Controller
    {
        private SintegraClient _sintegraClient;
        public PessoaJuridicaController(SintegraClient sintegraClient)
        {
            _sintegraClient = sintegraClient;
        }

        [HttpGet("PessoaJuridica/Cnpj")]
        public async Task<IActionResult> PessoaJuridica(string cnpj)
        {
            var pessoaJuridica = await _sintegraClient.GetPessoaJuridicaAsync(cnpj);
            return Ok(pessoaJuridica);
        }
    }
}
