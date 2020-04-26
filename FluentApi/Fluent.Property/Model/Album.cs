using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Property.Model
{
	public class Album
	{
		// Primary Key
		public int AlbumId { get; set; }


		// Properties
		public string Name { get; set; }
		[Column("Released", TypeName = "datetime2")]
		[ConcurrencyCheck]
		public DateTime ReleaseDate { get; set; }
		[Column("Format", TypeName = "nchar")]
		[StringLength(3)]
		public string Format { get; set; }
		// Decimal precision can only be set using Fluent API.  A custom attribute can be created for percision using reflection and Fluent API
		public decimal Length { get; set; }
		[Required]
		public string Studio { get; set; }
		public int? SinglesReleased { get; set; }
		

		// Relationships
		public int BandId { get; set; }
		public virtual Band Band { get; set; }
		public virtual List<Track> Tracks { get; private set; }
	}
}
