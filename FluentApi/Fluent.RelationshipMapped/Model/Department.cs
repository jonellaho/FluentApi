namespace Fluent.RelationshipMapped.Model
{
	public class Department
	{
		// Primary Key
		public int DepartmentId { get; set; }


		// Properties
		public string DepartmentName { get; set; }


		// Relationships - Table Splitting (Mapping Multiple Entity Types to One Table in the Database)
		public virtual Director Director { get; set; }
	}
}
