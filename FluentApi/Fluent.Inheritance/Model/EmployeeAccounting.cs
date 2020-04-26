using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Inheritance.Model
{
	[Table("EmployeeAccounting")]
	public class EmployeeAccounting : Employee
	{
		// Properties
		public string Certification { get; set; }
		public int SecurityLevel { get; set; }
	}
}
