using Fluent.RelationshipMapped.Model;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.RelationshipMapped.Map
{
	internal class DirectorMap : EntityTypeConfiguration<Director>
	{
		internal DirectorMap()
		{
			// Relationships - Table Splitting (Mapping Multiple Entity Types to One Table in the Database)

			HasKey(t => t.DepartmentId);

			ToTable("Department");
		}
	}
}
