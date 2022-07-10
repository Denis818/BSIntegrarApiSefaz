using AutoMapper;
using BSIntegrarApiSefaz.Domain;
using BSIntegrarApiSefaz.Domain.Dto.Sintegra;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BSIntegrarApiSefaz.ClienteWeb
{
    public class SintegraClient : ClientBase
    {
        private readonly SintegraApiDTO _sintegraConfig;

        public SintegraClient(IServiceProvider serviceProvider, IOptions<SintegraApiDTO> sintegraOptions) 
            : base(serviceProvider)
        {
            _sintegraConfig = sintegraOptions.Value;
            _UrlBase = _sintegraConfig.Url;
        }

        public async Task<PessoaJuridica> GetPessoaJuridicaAsync(string cnpj)
        {
            var pessoaJuridica = await GetAsync<PessoaJuridicaResponseDTO>($"imoveis/buscar?token={_sintegraConfig.Token}&plugin={_sintegraConfig.Plugin}&cnpj={cnpj}");
            return _mapper.Map<PessoaJuridica>(pessoaJuridica);               
        }
    }
}
