using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Relationship.Model
{
	public class Account
	{
		// Primary Key
		public int AccountId { get; set; }


		// Properties
		public string AccountType { get; set; }
		public string AccountNumber { get; set; }


		// Relationships - One-to-Many

		[ForeignKey("Customer")]
		public int CustomerId { get; set; }
		public virtual Customer Customer { get; set; }
	}
}
