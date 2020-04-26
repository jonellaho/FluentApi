using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Relationship.Model
{
	public class Address
	{
		// Primary Key
		[ForeignKey("Customer")]
		public int AddressId { get; set; }


		// Properties
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zipcode { get; set; }


		// Relationships - One-to-Zero-or-One
		public virtual Customer Customer { get; set; }
	}
}
