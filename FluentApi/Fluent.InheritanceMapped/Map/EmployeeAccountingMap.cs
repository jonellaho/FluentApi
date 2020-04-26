using Fluent.InheritanceMapped.Model;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.InheritanceMapped.Map
{
	internal class EmployeeAccountingMap : EntityTypeConfiguration<EmployeeAccounting>
	{
		internal EmployeeAccountingMap()
		{
			// Mapping the Table-Per-Type (TPT) Inheritance
			ToTable("EmployeeAccounting");
		}
	}
}
