using BSIntegrarApiSefaz.Domain.Dto.Correios;
using BSIntegrarApiSefaz.Domain.Dto.Sintegra;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BSIntegrarApiSefaz.Configuracao
{
    public static class ApiConfiguracoes
    {
        public static IServiceCollection MappearAppSettings(this IServiceCollection service, IConfiguration configuration)
        {
            //Mepeando os dados do appSetting.json para a model SintegraDTO.
            service.Configure<SintegraApiDTO>(configuration.GetSection("SintegraApi"));
            

            service.Configure<ConsultaCepDTO>(configuration.GetSection("CorreiosCep"));

            return service;
        }
    }
}
