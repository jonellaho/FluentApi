using Fluent.InheritanceMapped.Model;
using System.Data.Entity.ModelConfiguration;

namespace Fluent.InheritanceMapped.Map
{
	internal class BillingMap : EntityTypeConfiguration<Billing>
	{
		internal BillingMap()
		{
			// Mapping the Table-Per-Hierarchy (TPH) Inheritance
			Map<BillingBankAccount>(m => m.Requires("BillingType").HasValue("ACH"))
				.Map<BillingCreditCard>(m => m.Requires("BillingType").HasValue("CC"));
		}
	}
}
