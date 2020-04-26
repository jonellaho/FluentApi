using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Inheritance.Model
{
	[Table("EmployeeMarketing")]
	public class EmployeeMarketing : Employee
	{
		// Properties
		public string CoachName { get; set; }
		public decimal TotalSales { get; set; }
	}
}
