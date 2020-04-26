using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fluent.Relationship.Model
{
	public class Customer
	{
		// Primary Key
		public int CustomerId { get; set; }


		// Properties
		public string CustomerName { get; set; }


		// Relationships - One-to-Zero-or-One
		public virtual Address Address { get; set; }


		// Relationships - One-to-One
		//  One-to-one relationship is technically not possible in MS SQL Server. It will always be one-to-zero or one.
		//  EF forms One-to-One relationships on entities.
		[Required]
		public virtual Contact Contact { get; set; }


		// Relationships - One-to-Many
		public virtual List<Account> Accounts { get; set; }


		// Relationships - Many-to-Many
		public virtual List<Branch> Branches { get; set; }
	}
}
