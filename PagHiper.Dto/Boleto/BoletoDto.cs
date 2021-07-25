namespace PagHiper.Dto.Boleto
{
	public class BoletoDto
	{
		public Create_Request create_request { get; set; }
	}

	public class Create_Request
	{
		public string result { get; set; }
		public string response_message { get; set; }
		public string transaction_id { get; set; }
		public string created_date { get; set; }
		public string value_cents { get; set; }
		public string status { get; set; }
		public string order_id { get; set; }
		public string due_date { get; set; }
		public Bank_Slip bank_slip { get; set; }
		public string http_code { get; set; }
	}

	public class Bank_Slip
	{
		public string digitable_line { get; set; }
		public string url_slip { get; set; }
		public string url_slip_pdf { get; set; }
		public string bar_code_number_to_image { get; set; }
	}

}

