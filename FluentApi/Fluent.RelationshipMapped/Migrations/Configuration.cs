namespace Fluent.RelationshipMapped.Migrations
{
	using Model;
	using System.Collections.Generic;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<RelationshipMappedDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(RelationshipMappedDbContext context)
		{
			// Relationships - One-to-Zero-or-One
			List<Address> addresses = new List<Address>
				{
					new Address { AddressId = 1, Address1 = "5322 Otter Lane", Address2 = "Apt. 22", City = "Centerville", State = "UT", Zipcode = "84014" },
					new Address { AddressId = 2, Address1 = "1807 Glenwood St. NE", City = "Bountiful", State = "UT", Zipcode = "84010" }
				};


			// Relationships - One-to-One
			List<Contact> contacts = new List<Contact>
				{
					new Contact { ContactId = 1, PhoneNumber = "408-999-8888" },
					new Contact { ContactId = 2, PhoneNumber = "307-200-3266" },
					new Contact { ContactId = 3, PhoneNumber = "208-344-5523" }
				};


			// Relationships - One-to-Many
			List<Account> accounts = new List<Account>
				{
					new Account { AccountId = 1, AccountType = "Checking", AccountNumber = "053201300-1", CustomerId = 1 },
					new Account { AccountId = 2, AccountType = "Savings", AccountNumber = "053201300-2", CustomerId = 1 },
					new Account { AccountId = 3, AccountType = "Checking", AccountNumber = "053217712-1", CustomerId = 2 },
					new Account { AccountId = 4, AccountType = "Savings", AccountNumber = "053217712-2", CustomerId = 2 },
					new Account { AccountId = 5, AccountType = "Checking", AccountNumber = "053208858-1", CustomerId = 3 },
					new Account { AccountId = 6, AccountType = "Savings", AccountNumber = "053208858-2", CustomerId = 3 }
				};


			// Relationships - Many-to-Many
			List<Branch> branches = new List<Branch>
				{
					new Branch { BranchId = 1, BranchName = "Zions Bank Centerville" },
					new Branch { BranchId = 2, BranchName = "Zions Bank North Salt Lake" },
					new Branch { BranchId = 3, BranchName = "Zions Bank Bountiful" }
				};

			context.Customers.AddOrUpdate(
			  p => p.CustomerId,
			  new Customer { CustomerId = 1, CustomerName = "Jenine Diaz",
				  Branches = new List<Branch> { branches.FirstOrDefault(a => a.BranchId == 1), branches.FirstOrDefault(a => a.BranchId == 2) },
				  Accounts = new List<Account> { accounts.FirstOrDefault(a => a.AccountId == 1), accounts.FirstOrDefault(a => a.AccountId == 2) },
				  Address = addresses.FirstOrDefault(a => a.AddressId == 1),
				  Contact = contacts.FirstOrDefault(a => a.ContactId == 1)
			  },
			  new Customer { CustomerId = 1, CustomerName = "Howard Pichon",
				  Branches = new List<Branch> { branches.FirstOrDefault(a => a.BranchId == 2), branches.FirstOrDefault(a => a.BranchId == 3) },
				  Accounts = new List<Account> { accounts.FirstOrDefault(a => a.AccountId == 3), accounts.FirstOrDefault(a => a.AccountId == 4) },
				  Address = addresses.FirstOrDefault(a => a.AddressId == 2),
				  Contact = contacts.FirstOrDefault(a => a.ContactId == 2)
			  },
			  new Customer { CustomerId = 1, CustomerName = "Max Krone",
				  Branches = new List<Branch> { branches.FirstOrDefault(a => a.BranchId == 3) },
				  Accounts = new List<Account> { accounts.FirstOrDefault(a => a.AccountId == 5), accounts.FirstOrDefault(a => a.AccountId == 6) },
				  Contact = contacts.FirstOrDefault(a => a.ContactId == 3)
			  }
			);


			// Relationships - Table Splitting (Mapping Multiple Entity Types to One Table in the Database)
			List<Director> directors = new List<Director>
				{
					new Director { EmployeeId = 33, DirectorName = "Jay Guth" },
					new Director { EmployeeId = 12, DirectorName = "Charla Haith" },
					new Director { EmployeeId = 113, DirectorName = "Gabriel Walts" }
				};

			context.Departments.AddOrUpdate(
			  p => p.DepartmentId,
			  new Department { DepartmentId = 1, DepartmentName = "Accounting", Director = directors.FirstOrDefault(a => a.EmployeeId == 33) },
			  new Department { DepartmentId = 2, DepartmentName = "Marketing", Director = directors.FirstOrDefault(a => a.EmployeeId == 12) },
			  new Department { DepartmentId = 3, DepartmentName = "Human Resources", Director = directors.FirstOrDefault(a => a.EmployeeId == 113) }
			);


			// Relationships - Entity Splitting (Mapping Properties of an Entity Type to Multiple Tables in the Database)
			//   Entity splitting cannot be configured by using Data Annotation.
			//   You must use Fluent API for configuring entity splitting.
			context.RegionalOffices.AddOrUpdate(
			  p => p.RegionalOfficeId,
			  new RegionalOffice { RegionalOfficeId = 1, RegionalOfficeName = "Jackson Hole", Administrator = "Stephani Debonis", PhoneNumber = "307-200-3266" },
			  new RegionalOffice { RegionalOfficeId = 2, RegionalOfficeName = "Salt Lake City", Administrator = "Dustin Tassone", PhoneNumber = "800-974-8800" },
			  new RegionalOffice { RegionalOfficeId = 3, RegionalOfficeName = "Boise", Administrator = "Matt Wolter", PhoneNumber = "208-344-5523" }
			);
		}
	}
}
