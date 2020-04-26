using System;
using System.Collections.Generic;

namespace Fluent.PropertyMapped.Model
{
	public class Album
	{
		// Primary Key
		public int AlbumId { get; set; }

		// Properties
		public string Name { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string Format { get; set; }
		public decimal Length { get; set; }
		public string Studio { get; set; }
		public int SinglesReleased { get; set; }
		
		// Relationships
		public int BandId { get; set; }
		public virtual Band Band { get; set; }
		public virtual List<Track> Tracks { get; private set; }
	}
}
