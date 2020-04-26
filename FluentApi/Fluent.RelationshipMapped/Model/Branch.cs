using System.Collections.Generic;

namespace Fluent.RelationshipMapped.Model
{
	public class Branch
	{
		// Primary Key
		public int BranchId { get; set; }


		// Properties
		public string BranchName { get; set; }


		// Relationships - Many-to-Many
		public virtual List<Customer> Customers { get; set; }
	}
}
