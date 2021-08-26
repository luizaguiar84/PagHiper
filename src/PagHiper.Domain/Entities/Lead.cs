using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace PagHiper.Domain.Entities
{
    public class Lead : BaseEntity
    {
        [DisplayName("Data de cadastro")]
        public DateTime DataCadastro { get; set; }
        public DateTime LastUpdate { get; set; }

        public string Nome { get; set; }

        [DisplayName("E-Mail")]
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}