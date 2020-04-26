using Fluent.InheritanceMapped.Model;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.InheritanceMapped.Map
{
	internal class CustomerOnsiteMap : EntityTypeConfiguration<CustomerOnsite>
	{
		internal CustomerOnsiteMap()
		{
			// Mapping the Table-Per-Concrete Class (TPC) Inheritance
			Map(m =>
			{
				m.MapInheritedProperties();
				m.ToTable("CustomerOnsite");
			});
		}
	}
}
