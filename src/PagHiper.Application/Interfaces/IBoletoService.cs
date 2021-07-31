using System;
using PagHiper.Domain.Entities;
using PagHiper.Dto.Boleto;

namespace PagHiper.Application.Interfaces
{
    public interface IBoletoService
    {
        string GetPdfBoleto(Boleto boleto);
        string GetDigitableLineBoleto(Boleto boleto);
        BoletoDto GetBoleto(Boleto boleto);
        public Boleto GetAll();
        public Boleto GetById(Guid id);
        void Add(Boleto boleto);
        void Update(Boleto boleto);
        void Remove(Boleto boleto);
        bool Exists(Guid id);
    }
}