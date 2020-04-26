namespace Fluent.InheritanceMapped.Model
{
	public class BillingBankAccount : Billing
	{
		// Properties
		public string BankName { get; set; }
		public string Swift { get; set; }
	}
}
