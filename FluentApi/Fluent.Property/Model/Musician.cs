using System.ComponentModel.DataAnnotations;

namespace Fluent.Property.Model
{
	public class Musician
	{
		// Primary Key
		[Key]
		public int MusicianKey { get; set; }

		// Properties
		public string Name { get; set; }

		// Relationships
		public int BandId { get; set; }
		public virtual Band Band { get; set; }
	}
}
