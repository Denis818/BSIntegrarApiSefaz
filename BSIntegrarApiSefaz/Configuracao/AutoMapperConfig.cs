using AutoMapper;
using BSIntegrarApiSefaz.PerfisAutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace BSIntegrarApiSefaz.Configuracao
{
    public static  class AutoMapperConfig
    {
        public static IServiceCollection AutoMapperConfigPerfis(this IServiceCollection service)
        {
            //audicionando o meu perfil de autoMapper ja existente nas cofigurações.
            var configuration = new MapperConfiguration(cfg => {               
                cfg.AddProfile<SintegraMapperProfile>();
            });

            //criando o meu Mapper, e injetanto ele no conteiner ID.
            var mapper = configuration.CreateMapper();
            service.AddSingleton(mapper);
            return service;
        }
    }
}
