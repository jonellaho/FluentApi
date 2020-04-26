namespace Fluent.Inheritance.Model
{
	public abstract class Billing
	{
		// Primary Key
		public int BillingId { get; set; }

		// Properties
		public string Owner { get; set; }
		public string Number { get; set; }
	}
}
