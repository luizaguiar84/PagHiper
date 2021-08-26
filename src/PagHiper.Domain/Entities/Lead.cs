using System;
using System.Xml.Linq;

namespace PagHiper.Domain.Entities
{
    public class Lead : BaseEntity
    {
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}