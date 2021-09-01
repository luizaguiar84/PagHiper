using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PagHiper.Domain.Entities
{
    public class Lead : BaseEntity
    {
        [DisplayName("Data de cadastro")]
        public DateTime DataCadastro { get; set; }
        public DateTime LastUpdate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public bool AceitaPropaganda { get; set; }

        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [Required]
        [MaxLength(14)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [MaxLength(7)]
        public string Cupom { get; set; }
    }
}