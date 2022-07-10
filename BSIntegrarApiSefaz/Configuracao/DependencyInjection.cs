using BSIntegrarApiSefaz.ClienteWeb;
using Microsoft.Extensions.DependencyInjection;

namespace BSIntegrarApiSefaz.Configuracao
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependency(this IServiceCollection service)
        {
            //extentendo o metodo configureService da class startup.
            service.AddHttpClient();
            service.AddScoped<SintegraClient>();
            service.AddScoped<ViaCep>();
            return service;
        }
    }
}
