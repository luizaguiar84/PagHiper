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

        [Required(ErrorMessage = "Inserir o nome")]
        [MaxLength(100, ErrorMessage = "Tamanho do nome inválido, favor inserir um valor até 100 caracteres.")]
        public string Nome { get; set; }

        public bool AceitaPropaganda { get; set; }

        [MaxLength(50, ErrorMessage = "Tamanho do E-mail inválido!")]
        [EmailAddress(ErrorMessage = "Por favor, insira um e-mail válido")]
        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Favor inserir um número de telefone válido")]
        [MaxLength(14)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [MaxLength(7)]
        public string Cupom { get; set; }
    }
}