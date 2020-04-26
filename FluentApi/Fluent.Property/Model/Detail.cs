using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Property.Model
{
	[ComplexType]
	public class Detail
	{
		// Properties
		public int DetailId { get; set; }
		public int? Length { get; set; }
	}
}
