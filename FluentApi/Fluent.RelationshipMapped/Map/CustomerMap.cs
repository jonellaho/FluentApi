using Fluent.RelationshipMapped.Model;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.RelationshipMapped.Map
{
	internal class CustomerMap : EntityTypeConfiguration<Customer>
	{
		internal CustomerMap()
		{
			// Relationships - One-to-Zero-or-One
			HasOptional(s => s.Address)
				.WithRequired(ad => ad.Customer);


			// Relationships - One-to-One
			//  One-to-one relationship is technically not possible in MS SQL Server. It will always be one-to-zero or one.
			//  EF forms One-to-One relationships on entities.
			HasRequired(s => s.Contact)
				.WithRequiredPrincipal(ad => ad.Customer);


			// Relationships - Many-to-Many
			HasMany(s => s.Branches)
				.WithMany(c => c.Customers)
				.Map(cs =>
				{
					cs.ToTable("CustomerBranch");
					cs.MapLeftKey("CustomerId");
					cs.MapRightKey("BranchId");
				});
		}
	}
}
