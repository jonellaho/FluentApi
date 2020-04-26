using Fluent.Relationship.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Fluent.Relationship
{
	public class RelationshipDbContext : DbContext
	{
		public RelationshipDbContext() : base("name=FluentRelationship_Connection")
		{
		}

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Branch> Branches { get; set; }

		public DbSet<Department> Departments { get; set; }
		public DbSet<Director> Directors { get; set; }

		public DbSet<RegionalOffice> RegionalOffices { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			// Remove Pluralization
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}
	}
}
