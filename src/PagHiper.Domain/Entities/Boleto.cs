using System.Collections.Generic;

namespace PagHiper.Domain.Entities
{
	public class Boleto : BaseEntity
	{
		public string ApiKey { get; set; }
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
		public string PartnersId { get; set; }
		public string SellerDescription { get; set; }
		public string LatePaymentFine { get; set; }
		public string PerDayInterest { get; set; }
		public string EarlyPaymentDiscountsDays { get; set; }
		public string EarlyPaymentDiscountsCents { get; set; }
		public string OpenAfterDayDue { get; set; }
		public bool FixedDescription { get; set; }
		public string DaysDueDate { get; set; }
		public string TypeBankSlip { get; set; }
		public IEnumerable<Item> Items { get; set; }
	}

	public class Item : BaseEntity
	{
		public int BoletoId { get; set; }
		public Boleto Boleto { get; set; }
		public string Description { get; set; }
		public string Quantity { get; set; }
		public string ItemId { get; set; }
		public string PriceCents { get; set; }
	}
}