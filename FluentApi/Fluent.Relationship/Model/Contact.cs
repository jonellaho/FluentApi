using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Relationship.Model
{
	public class Contact
	{
		// Primary Key
		[ForeignKey("Customer")]
		public int ContactId { get; set; }


		// Properties
		public string PhoneNumber { get; set; }


		// Relationships - One-to-One
		public virtual Customer Customer { get; set; }
	}
}
