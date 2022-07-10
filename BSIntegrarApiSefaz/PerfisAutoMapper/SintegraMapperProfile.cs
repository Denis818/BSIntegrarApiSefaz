using AutoMapper;
using BSIntegrarApiSefaz.Domain;
using BSIntegrarApiSefaz.Domain.Dto.Sintegra;

namespace BSIntegrarApiSefaz.PerfisAutoMapper
{
    public class SintegraMapperProfile : Profile
    {
        public SintegraMapperProfile()
        {
            //criando um perfil de autoMapper.
            CreateMap<PessoaJuridicaResponseDTO, PessoaJuridica>()
                .ForMember(destino => destino.Cnpj, option => option.MapFrom(font => font.cnpj))
                .ForMember(destino => destino.InscricaoEstadual, option => option.MapFrom(font => font.inscricao_estadual))
                .ForMember(destino => destino.UnidadeFederativaRG, option => option.MapFrom(font => font.uf))
                .ForMember(destino => destino.Fantasia, option => option.MapFrom(font => font.nome_fantasia))

                .ForPath(destino => destino.Endereco.Numero, option => option.MapFrom(font => font.numero))
                //.ForPath(destino => destino.Endereco.Cidade, option => option.MapFrom(font => font.cidade))
                .ForPath(destino => destino.Endereco.Cep, option => option.MapFrom(font => font.cep))
                .ForPath(destino => destino.Endereco.Bairro, option => option.MapFrom(font => font.bairro))
                .ForPath(destino => destino.Endereco.Enderecoo, option => option.MapFrom(font => font.logradouro));
                //.ForPath(destino => destino.Endereco.CodicoIbgeMunicipio, option => option.MapFrom(font => font.ibg))
                //.ForPath(destino => destino.Endereco.Pais, option => option.MapFrom(font => font.pais));
        }
    }
}
