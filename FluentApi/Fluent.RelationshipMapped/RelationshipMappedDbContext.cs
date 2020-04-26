using Fluent.RelationshipMapped.Map;
using Fluent.RelationshipMapped.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Fluent.RelationshipMapped
{
	public class RelationshipMappedDbContext : DbContext
	{
		public RelationshipMappedDbContext() : base("name=FluentRelationshipMapped_Connection")
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
			// Relationships - One-to-Zero-or-One
			// Relationships - One-to-One
			// Relationships - One-to-Many
			// Relationships - Many-to-Many
			// Relationships - Table Splitting (Mapping Multiple Entity Types to One Table in the Database)
			// Relationships - Entity Splitting (Mapping Properties of an Entity Type to Multiple Tables in the Database)
			
			modelBuilder.Configurations.Add(new AccountMap());
			modelBuilder.Configurations.Add(new CustomerMap());
			modelBuilder.Configurations.Add(new DepartmentMap());
			modelBuilder.Configurations.Add(new DirectorMap());
			modelBuilder.Configurations.Add(new RegionalOfficeMap());

			// Remove Pluralization
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}
	}
}
