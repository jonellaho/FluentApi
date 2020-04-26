using Fluent.RelationshipMapped.Model;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.RelationshipMapped.Map
{
	internal class RegionalOfficeMap : EntityTypeConfiguration<RegionalOffice>
	{
		internal RegionalOfficeMap()
		{
			// Relationships - Entity Splitting (Mapping Properties of an Entity Type to Multiple Tables in the Database)
			Map(m =>
				{
					m.Properties(t => new { t.RegionalOfficeId, t.RegionalOfficeName });
					m.ToTable("RegionalOffice");
				})
				.Map(m =>
				{
					m.Properties(t => new { t.RegionalOfficeId, t.Administrator, t.PhoneNumber });
					m.ToTable("RegionalOfficeDetail");
				});
		}
	}
}
