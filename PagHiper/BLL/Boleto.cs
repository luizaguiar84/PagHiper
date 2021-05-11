using System;
using Newtonsoft.Json;
using PagHiper.Models;
using PagHiper.Services;
using RestSharp;

namespace PagHiper.BLL
{
	public class Boleto
	{
		public string GetPdfBoleto(Models.Boleto boleto)
		{
			var returnTicket = GetBoleto(boleto);
			return returnTicket.create_request.bank_slip.url_slip_pdf;
		}

		public string GetDigitableLineBoleto(Models.Boleto boleto)
		{
			var response = GetBoleto(boleto);
			return response.create_request.bank_slip.digitable_line;
		}

		private BoletoResponse GetBoleto(Models.Boleto boleto)
		{
			var response = RequestService.GetResponse("/transaction/create/", boleto);
			if (!response.IsSuccessful)
				throw new Exception("Erro na requisição!");

			var returnTicket = JsonConvert.DeserializeObject<BoletoResponse>(response.Content);

			return returnTicket ?? throw new NullReferenceException("Erro na geração do boleto");

		}
	}
}
