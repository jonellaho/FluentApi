using Fluent.InheritanceMapped.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace Fluent.InheritanceMapped
{
	public class InheritanceMappedDbContext : DbContext
	{
		public InheritanceMappedDbContext() : base("name=FluentInheritanceMapped_Connection")
		{
		}

		public DbSet<Billing> Billings { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Customer> Customers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(GetType()));

			// Remove Pluralization
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}
	}
}
