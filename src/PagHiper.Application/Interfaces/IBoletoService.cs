using System;
using PagHiper.Domain.Entities;
using PagHiper.Dto.Boleto;

namespace PagHiper.Application.Interfaces
{
    public interface IBoletoService
    {
	    public string GetPdfBoleto(Boleto boleto);
	    public string GetDigitableLineBoleto(Boleto boleto);
	    public BoletoDto GetBoleto(Boleto boleto);
	    public Boleto GetAll();
        public Boleto GetById(Guid id);
        public void Add(Boleto boleto);
        public void Update(Boleto boleto);
        public void Remove(Boleto boleto);
        public bool Exists(Guid id);
    }
}