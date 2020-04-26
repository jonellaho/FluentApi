using Fluent.RelationshipMapped.Model;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.RelationshipMapped.Map
{
	internal class AccountMap : EntityTypeConfiguration<Account>
	{
		internal AccountMap()
		{
			// Relationships - One-to-Many
			HasRequired(s => s.Customer)
					.WithMany(s => s.Accounts);
		}
	}
}
