using BSIntegrarApiSefaz.Domain.Dto.Correios;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace BSIntegrarApiSefaz.ClienteWeb
{
    public class ViaCep : ClientBase
    {
        private readonly ConsultaCepDTO _consultaCepDTO;
        public ViaCep(IServiceProvider serviceProvider, IOptions<ConsultaCepDTO> consultaCepDTO) : base(serviceProvider)
        {
            _consultaCepDTO = consultaCepDTO.Value;
            _UrlBase = _consultaCepDTO.url;
        }

        public async Task<CepCorreiosDTO> GetCep(string cep)
        {
            var resultCep = await GetAsync<CepCorreiosDTO>($"{cep}/json");

            return resultCep;
        }
    }
}
