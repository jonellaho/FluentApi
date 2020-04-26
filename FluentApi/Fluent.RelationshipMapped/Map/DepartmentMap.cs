using Fluent.RelationshipMapped.Model;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.RelationshipMapped.Map
{
	internal class DepartmentMap : EntityTypeConfiguration<Department>
	{
		internal DepartmentMap()
		{
			// Relationships - Table Splitting (Mapping Multiple Entity Types to One Table in the Database)

			HasRequired(t => t.Director)
				.WithRequiredPrincipal(t => t.Department);

			ToTable("Department");
		}
	}
}
