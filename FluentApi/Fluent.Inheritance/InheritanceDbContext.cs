using Fluent.Inheritance.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Fluent.Inheritance
{
	public class InheritanceDbContext : DbContext
	{
		public InheritanceDbContext() : base("name=FluentInheritance_Connection")
		{
		}

		public DbSet<Billing> Billings { get; set; }
		public DbSet<Employee> Employees { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			// Remove Pluralization
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}
	}
}
