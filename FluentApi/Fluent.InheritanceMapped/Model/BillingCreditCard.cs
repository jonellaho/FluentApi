namespace Fluent.InheritanceMapped.Model
{
	public class BillingCreditCard : Billing
	{
		// Properties
		public int CardType { get; set; }
		public string ExpiryMonth { get; set; }
		public string ExpiryYear { get; set; }
	}
}
