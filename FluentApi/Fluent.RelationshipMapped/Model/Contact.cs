namespace Fluent.RelationshipMapped.Model
{
	public class Contact
	{
		// Primary Key
		public int ContactId { get; set; }


		// Properties
		public string PhoneNumber { get; set; }


		// Relationships - One-to-One
		public virtual Customer Customer { get; set; }
	}
}
