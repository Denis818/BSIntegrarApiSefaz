using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSIntegrarApiSefaz.Domain
{
    public class Endereco
    {
        public string Enderecoo { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string CodicoIbgeMunicipio { get; set; }
        public string Pais { get; set; }
    }
}
