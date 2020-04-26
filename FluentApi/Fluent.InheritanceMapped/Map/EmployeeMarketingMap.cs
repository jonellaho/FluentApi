using Fluent.InheritanceMapped.Model;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.InheritanceMapped.Map
{
	internal class EmployeeMarketingMap : EntityTypeConfiguration<EmployeeMarketing>
	{
		internal EmployeeMarketingMap()
		{
			// Mapping the Table-Per-Type (TPT) Inheritance
			ToTable("EmployeeMarketing");
		}
	}
}
