using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Property.Model
{
	public class Band
	{
		// Primary Key
		public int BandId { get; set; }

		// Properties
		[MaxLength(50)]
		[Index("Index")]
		public string Name { get; set; }
		[NotMapped]
		public decimal NetWorth { get; set; }

		// Relationships
		public virtual List<Musician> Musicians { get; private set; }
		public virtual List<Album> Albums { get; private set; }
	}
}
