using System;
using Newtonsoft.Json;
using PagHiper.Application.Interfaces;
using PagHiper.Application.Requests;
using PagHiper.Domain.Entities;
using PagHiper.Dto.Boleto;

namespace PagHiper.Application.Services
{
	public class BoletoService : IBoletoService
	{
		public string GetPdfBoleto(Boleto boleto)
		{
			try
			{
				var returnTicket = GetBoleto(boleto);
				return returnTicket.create_request.bank_slip.url_slip_pdf;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public string GetDigitableLineBoleto(Boleto boleto)
		{
			try
			{
				var response = GetBoleto(boleto);
				return response.create_request.bank_slip.digitable_line;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public BoletoDto GetBoleto(Boleto boleto)
		{
			var response = DoRequest.Post("/transaction/create/", boleto);
			if (!response.IsSuccessful)
				throw new Exception("Erro na requisição!");

			var returnTicket = JsonConvert.DeserializeObject<BoletoDto>(response.Content);

			if (returnTicket != null && returnTicket.create_request.result == "reject")
			{
				throw new Exception($"Erro na requisição! - erro: {returnTicket.create_request.response_message}");
			}

			throw new NullReferenceException("Erro na geração do boleto!");

		}

		public Boleto GetAll()
		{
			throw new NotImplementedException();
		}

		public Boleto GetById(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Add(Boleto boleto)
		{
			throw new NotImplementedException();
		}

		public void Update(Boleto boleto)
		{
			throw new NotImplementedException();
		}

		public void Remove(Boleto boleto)
		{
			throw new NotImplementedException();
		}

		public bool Exists(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
