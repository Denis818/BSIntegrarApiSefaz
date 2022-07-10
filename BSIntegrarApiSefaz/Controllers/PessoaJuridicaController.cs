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

        [HttpGet("PessoaJuridica")]
        public async Task<IActionResult> PessoaJuridica()
        {
            var pessoaJuridica = await _sintegraClient.GetPessoaJuridicaAsync("765987790dd8");
            return Ok(pessoaJuridica);
        }
    }
}
