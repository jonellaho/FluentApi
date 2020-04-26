namespace Fluent.InheritanceMapped.Model
{
	public abstract class Customer
	{
		// Primary Key
		public int CustomerId { get; set; }

		// Properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
