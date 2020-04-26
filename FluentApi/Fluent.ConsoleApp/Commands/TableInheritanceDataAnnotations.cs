using System;
using System.Linq;
using Fluent.Inheritance;
using Fluent.Inheritance.Model;

namespace Fluent.ConsoleApp.Commands
{
	public static class TableInheritanceDataAnnotations
	{
		public static void Get()
		{
			Console.WriteLine();
			using (var db = new InheritanceDbContext())
			{
				var billings = db.Billings;

				Console.WriteLine("All Billing Accounts:");
				Console.WriteLine();
				foreach (var billing in billings)
				{
					Console.WriteLine("\t" + billing.GetType().Name + " - Id: " + billing.BillingId + " - Owner: " + billing.Owner);
					if (billing is BillingBankAccount)
					{
						var bankAccount = (BillingBankAccount)billing;
						Console.WriteLine("\t - Bank Name: " + bankAccount.BankName + " - Number: " + bankAccount.Number + " - Swift: " + bankAccount.Swift);
					}
					else if (billing is BillingCreditCard)
					{
						var creditCard = (BillingCreditCard)billing;
						Console.WriteLine("\t - Card Type: " + creditCard.CardType + " - Number: " + creditCard.Number +
							" - Expire Month: " + creditCard.ExpiryMonth + " - Expire Year: " + creditCard.ExpiryYear);
					}
					Console.WriteLine();
				}


				var billingBankAccounts = db.Billings
					.OfType<BillingBankAccount>();

				Console.WriteLine("Bank Accounts:");
				Console.WriteLine();
				foreach (var bankAccount in billingBankAccounts)
				{
					Console.WriteLine("\t" + bankAccount.Owner + " - Id: " + bankAccount.BillingId);
					Console.WriteLine("\t - Bank Name: " + bankAccount.BankName + " - Number: " + bankAccount.Number + " - Swift: " + bankAccount.Swift);
					Console.WriteLine();
				}


				var billingCreditCards = db.Billings
					.OfType<BillingCreditCard>();

				Console.WriteLine("Credit Cards:");
				Console.WriteLine();
				foreach (var creditCard in billingCreditCards)
				{
					Console.WriteLine("\t" + creditCard.Owner + " - Id: " + creditCard.BillingId);
					Console.WriteLine("\t - Card Type: " + creditCard.CardType + " - Number: " + creditCard.Number +
						" - Expire Month: " + creditCard.ExpiryMonth + " - Expire Year: " + creditCard.ExpiryYear);
					Console.WriteLine();
				}
				Console.WriteLine();


				var employees = db.Employees;

				Console.WriteLine("All Employees:");
				Console.WriteLine();
				foreach (var employee in employees)
				{
					Console.WriteLine("\t" + employee.GetType().Name + " - Id: " + employee.EmployeeId + " - Name: " + employee.FirstName + " " + employee.LastName);
					if (employee is EmployeeAccounting)
					{
						var accountingEmployee = (EmployeeAccounting)employee;
						Console.WriteLine("\t - Security Level: " + accountingEmployee.SecurityLevel + " - Certification: " + accountingEmployee.Certification);
					}
					else if (employee is EmployeeMarketing)
					{
						var marketingEmployee = (EmployeeMarketing)employee;
						Console.WriteLine("\t - Total Sales: $" + marketingEmployee.TotalSales + " - Coach Name: " + marketingEmployee.CoachName);
					}
					Console.WriteLine();
				}


				var accountingEmployees = db.Employees
					.OfType<EmployeeAccounting>();

				Console.WriteLine("Accounting Employees:");
				Console.WriteLine();
				foreach (var accountingEmployee in accountingEmployees)
				{
					Console.WriteLine("\t" + accountingEmployee.FirstName + " " + accountingEmployee.LastName + " - Id: " + accountingEmployee.EmployeeId);
					Console.WriteLine("\t - Security Level: " + accountingEmployee.SecurityLevel + " - Certification: " + accountingEmployee.Certification);
					Console.WriteLine();
				}


				var marketingEmployees = db.Employees
					.OfType<EmployeeMarketing>();

				Console.WriteLine("Marketing Employees:");
				Console.WriteLine();
				foreach (var marketingEmployee in marketingEmployees)
				{
					Console.WriteLine("\t" + marketingEmployee.FirstName + " " + marketingEmployee.LastName + " - Id: " + marketingEmployee.EmployeeId);
					Console.WriteLine("\t - Total Sales: $" + marketingEmployee.TotalSales + " - Coach Name: " + marketingEmployee.CoachName);
					Console.WriteLine();
				}
			}
		}
	}
}
