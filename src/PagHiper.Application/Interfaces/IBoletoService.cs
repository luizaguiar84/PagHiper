using PagHiper.Domain.Entities;
using PagHiper.Dto.Boleto;

namespace PagHiper.Application.Interfaces
{
    public interface IBoletoService
    {
        string GetPdfBoleto(Boleto boleto);
        string GetDigitableLineBoleto(Boleto boleto);
        BoletoDto GetBoleto(Boleto boleto);
    }
}