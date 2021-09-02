using System;
using PagHiper.Domain.Entities;
using PagHiper.Dto.Boleto;

namespace PagHiper.Application.Interfaces
{
    public interface IBoletoService
    {
	    public string GetPdfBoleto(Boleto boleto);
	    public string GetDigitableLineBoleto(Boleto boleto);
	    public BoletoResponseDto GetBoleto(Boleto boleto);
	    public Boleto GetAll();
        public Boleto GetById(int id);
        public void Add(Boleto boleto);
        public void Update(Boleto boleto);
        public void Remove(Boleto boleto);
        public bool Exists(int id);
    }
}