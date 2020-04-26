using System;
using System.Data.Entity;
using Fluent.Relationship;

namespace Fluent.ConsoleApp.Commands
{
	public static class RelationshipsDataAnnotations
	{
		public static void Get()
		{
			Console.WriteLine();
			using (var db = new RelationshipDbContext())
			{
				var customers = db.Customers
					.Include(i => i.Address)
					.Include(i => i.Contact)
					.Include(i => i.Branches)
					.Include(i => i.Accounts);

				Console.WriteLine("Customers:");
				Console.WriteLine();
				foreach (var customer in customers)
				{
					Console.WriteLine("\t" + customer.CustomerName + " - Id: " + customer.CustomerId);
					Console.WriteLine("\t - PhoneNumber: " + customer.Contact.PhoneNumber);
					if (customer.Address != null)
					{
						Console.WriteLine("\t - Address: " + customer.Address.Address1 + " " + customer.Address.Address2 +
							" - " + customer.Address.City + ", " + customer.Address.State + " " + customer.Address.Zipcode);
					}
					Console.WriteLine("\t - Accounts: ");
					foreach (var account in customer.Accounts)
					{
						Console.WriteLine("\t\t - " + account.AccountType + "  " + account.AccountNumber);
					}
					Console.WriteLine("\t - Branches: ");
					foreach (var branch in customer.Branches)
					{
						Console.WriteLine("\t\t - " + branch.BranchName);
					}
					Console.WriteLine();
				}

				var departments = db.Departments
					.Include(i => i.Director);

				Console.WriteLine("Departments:");
				Console.WriteLine();
				foreach (var department in departments)
				{
					Console.WriteLine("\t" + department.DepartmentName + " - Id: " + department.DepartmentId);
					Console.WriteLine("\t - DirectorName: " + department.Director.DirectorName + " - EmployeeId: " + department.Director.EmployeeId);
					Console.WriteLine();
				}

				var regionalOffices = db.RegionalOffices;

				Console.WriteLine("Regional Offices:");
				Console.WriteLine();
				foreach (var regionalOffice in regionalOffices)
				{
					Console.WriteLine("\t" + regionalOffice.RegionalOfficeName + " - Id: " + regionalOffice.RegionalOfficeId);
					Console.WriteLine("\t - Administrator: " + regionalOffice.Administrator);
					Console.WriteLine("\t - PhoneNumber: " + regionalOffice.PhoneNumber);
					Console.WriteLine();
				}
			}
		}
	}
}
