using System;

namespace BSIntegrarApiSefaz.Domain
{
    public class PessoaJuridica
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string UnidadeFederativaRG { get; set; }
        public string Fone { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Fantasia { get; set; }
        public Endereco Endereco { get; set; }
    }
}
