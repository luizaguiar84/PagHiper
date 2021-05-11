using System;
using Newtonsoft.Json;
using PagHiper.Models;
using PagHiper.Requests;
using PagHiper.Requests;

namespace PagHiper.BLL
{
	public class Boleto
	{
		public string GetPdfBoleto(Models.Boleto boleto)
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

		public string GetDigitableLineBoleto(Models.Boleto boleto)
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

		private BoletoResponse GetBoleto(Models.Boleto boleto)
		{
			var response = DoRequest.Post("/transaction/create/", boleto);
			if (!response.IsSuccessful)
				throw new Exception("Erro na requisição!");

			var returnTicket = JsonConvert.DeserializeObject<BoletoResponse>(response.Content);

			if (returnTicket is not null && returnTicket.create_request.result == "reject")
			{
				throw new Exception($"Erro na requisição! - erro: {returnTicket.create_request.response_message}");
			}

			throw new NullReferenceException("Erro na geração do boleto!");

		}
	}
}
