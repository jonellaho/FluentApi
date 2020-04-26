namespace Fluent.InheritanceMapped.Model
{
	public abstract class Employee
	{
		// Primary Key
		public int EmployeeId { get; set; }

		// Properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
