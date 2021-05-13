using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PagHiper.Models
{
	public class Boleto
	{
		public Boleto()
		{
			this.items = new List<Item>();
		}
		public string apiKey { get; set; }
		[Key]
		public string order_id { get; set; }
		public string payer_email { get; set; }
		public string payer_name { get; set; }
		public string payer_cpf_cnpj { get; set; }
		public string payer_phone { get; set; }
		public string payer_street { get; set; }
		public string payer_number { get; set; }
		public string payer_complement { get; set; }
		public string payer_district { get; set; }
		public string payer_city { get; set; }
		public string payer_state { get; set; }
		public string payer_zip_code { get; set; }
		public string notification_url { get; set; }
		public string discount_cents { get; set; }
		public string shipping_price_cents { get; set; }
		public string shipping_methods { get; set; }
		public bool fixed_description { get; set; }
		public string days_due_date { get; set; }
		public string type_bank_slip { get; set; }
		public IEnumerable<Item> items { get; set; }
	}

	public class Item
	{
		public string description { get; set; }
		public string quantity { get; set; }
		[Key]
		public string item_id { get; set; }
		public string price_cents { get; set; }
		public string Boleto_OrderId { get; set; }
	}

}

