using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Relationship.Model
{
	[Table("Department")]
	public class Director
	{
		// Primary Key
		[Key(),ForeignKey("Department")]
		public int DepartmentId { get; set; }


		// Properties
		public int EmployeeId { get; set; }
		public string DirectorName { get; set; }


		// Relationships - Table Splitting (Mapping Multiple Entity Types to One Table in the Database)
		public virtual Department Department { get; set; }

	}
}
