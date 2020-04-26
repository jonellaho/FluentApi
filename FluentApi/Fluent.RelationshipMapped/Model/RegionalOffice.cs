namespace Fluent.RelationshipMapped.Model
{
	public class RegionalOffice
	{
		// Primary Key
		public int RegionalOfficeId { get; set; }


		// Properties
		public string RegionalOfficeName { get; set; }
		public string Administrator { get; set; }
		public string PhoneNumber { get; set; }
	}
}
