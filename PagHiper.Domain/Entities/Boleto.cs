using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PagHiper.Domain.Entities
{
	public class Boleto
	{
		public Boleto()
		{
			this.Items = new List<Item>();
		}
		public string ApiKey { get; set; }
		[Key]
		public string OrderId { get; set; }
		public string PayerEmail { get; set; }
		public string PayerName { get; set; }
		public string PayerCpfCnpj { get; set; }
		public string PayerPhone { get; set; }
		public string PayerStreet { get; set; }
		public string PayerNumber { get; set; }
		public string PayerComplement { get; set; }
		public string PayerDistrict { get; set; }
		public string PayerCity { get; set; }
		public string PayerState { get; set; }
		public string PayerZipCode { get; set; }
		public string NotificationUrl { get; set; }
		public string DiscountCents { get; set; }
		public string ShippingPriceCents { get; set; }
		public string ShippingMethods { get; set; }
		public bool FixedDescription { get; set; }
		public string DaysDueDate { get; set; }
		public string TypeBankSlip { get; set; }
		public IEnumerable<Item> Items { get; set; }
	}

	public class Item
	{
		public string Description { get; set; }
		public string Quantity { get; set; }
		[Key]
		public string ItemId { get; set; }
		public string PriceCents { get; set; }
		public string BoletoOrderId { get; set; }
	}

}

