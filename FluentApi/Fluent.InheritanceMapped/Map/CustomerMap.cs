using Fluent.InheritanceMapped.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.InheritanceMapped.Map
{
	internal class CustomerMap : EntityTypeConfiguration<Customer>
	{
		internal CustomerMap()
		{
			// Mapping the Table-Per-Concrete Class (TPC) Inheritance
			Property(c => c.CustomerId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
		}
	}
}
