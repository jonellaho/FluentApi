namespace Fluent.InheritanceMapped.Migrations
{
	using Model;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<InheritanceMappedDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(InheritanceMappedDbContext context)
		{
			// Table-Per-Hierarchy (TPH) Inheritance
			context.Billings.AddOrUpdate(
			  p => p.BillingId,
			  new BillingBankAccount { BillingId = 1, Owner = "Frank Jones", Number = "0532013006", BankName = "Apollo Bank", Swift = "UCBMUS3M" },
			  new BillingBankAccount { BillingId = 2, Owner = "Nellie Souliere", Number = "2010083000", BankName = "Bank Of America", Swift = "BOFAUS6SMET" },
			  new BillingBankAccount { BillingId = 3, Owner = "Garret Hilt", Number = "3041465010", BankName = "Hsbc Bank Usa", Swift = "MRMDUS33GCS" },
			  new BillingCreditCard { BillingId = 4, Owner = "Lucy Reddick", Number = "4111111111111111", CardType = 1, ExpiryMonth = "10", ExpiryYear = "17" },
			  new BillingCreditCard { BillingId = 5, Owner = "Charlott Ewin", Number = "5500000000000004", CardType = 2, ExpiryMonth = "02", ExpiryYear = "20" },
			  new BillingCreditCard { BillingId = 6, Owner = "Pete Smoak", Number = "340000000000009", CardType = 3, ExpiryMonth = "08", ExpiryYear = "18" }
			);


			// Table-Per-Type (TPT) Inheritance
			context.Employees.AddOrUpdate(
			  p => p.EmployeeId,
			  new EmployeeAccounting { EmployeeId = 1, FirstName = "Brittany", LastName = "Kubat", Certification = "Certified Public Accountant (CPA)", SecurityLevel = 1 },
			  new EmployeeAccounting { EmployeeId = 2, FirstName = "Steve", LastName = "Bischoff", Certification = "Certified Internal Auditor (CIA)", SecurityLevel = 2 },
			  new EmployeeAccounting { EmployeeId = 3, FirstName = "Cristopher", LastName = "McComb", Certification = "Certified Fraud Examiner (CFE)", SecurityLevel = 3 },
			  new EmployeeMarketing { EmployeeId = 4, FirstName = "Jena", LastName = "Staats", CoachName = "Diana Carpentier", TotalSales = 6234.49m },
			  new EmployeeMarketing { EmployeeId = 5, FirstName = "Shayne", LastName = "Henley", CoachName = "Charleen Rhodes", TotalSales = 58632.12m },
			  new EmployeeMarketing { EmployeeId = 6, FirstName = "Jefferey", LastName = "Merriweather", CoachName = "Kathey Quan", TotalSales = 12498.34m }
			);


			// Table-Per-Concrete Class (TPC) Inheritance
			context.Customers.AddOrUpdate(
			  p => p.CustomerId,
			  new CustomerOnline { CustomerId = 1, FirstName = "Alysha", LastName = "Ariza", UserName = "aariza", Email = "aariza@gmail.com" },
			  new CustomerOnline { CustomerId = 2, FirstName = "Dustin", LastName = "Sweeney", UserName = "dsweeney", Email = "dsweeney@gmail.com" },
			  new CustomerOnline { CustomerId = 3, FirstName = "Keri", LastName = "Kothari", UserName = "kkothari", Email = "kkothari@gmail.com" },
			  new CustomerOnsite { CustomerId = 4, FirstName = "Joey", LastName = "Colter", Location = "Downtown", Phone = "541-754-3010" },
			  new CustomerOnsite { CustomerId = 5, FirstName = "Janice", LastName = "Hudnall", Location = "Bountiful", Phone = "311-555-2368" },
			  new CustomerOnsite { CustomerId = 6, FirstName = "Mauro", LastName = "Cantor", Location = "Sandy", Phone = "801-867-5309" }
			);
		}
	}
}
