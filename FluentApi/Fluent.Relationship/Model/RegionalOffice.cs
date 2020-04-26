namespace Fluent.Relationship.Model
{
	public class RegionalOffice
	{
		// Primary Key
		public int RegionalOfficeId { get; set; }


		// Properties
		public string RegionalOfficeName { get; set; }
		public string Administrator { get; set; }
		public string PhoneNumber { get; set; }


		// Relationships - Entity Splitting (Mapping Properties of an Entity Type to Multiple Tables in the Database)
		//   Entity splitting cannot be configured by using Data Annotation.
		//   You must use Fluent API for configuring entity splitting.
	}
}
