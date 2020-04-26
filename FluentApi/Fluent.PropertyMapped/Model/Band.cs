using System.Collections.Generic;

namespace Fluent.PropertyMapped.Model
{
	public class Band
	{
		// Primary Key
		public int BandId { get; set; }
		
		// Properties
		public string Name { get; set; }
		public decimal NetWorth { get; set; }

		// Relationships
		public virtual List<Musician> Musicians { get; private set; }
		public virtual List<Album> Albums { get; private set; }
	}
}
