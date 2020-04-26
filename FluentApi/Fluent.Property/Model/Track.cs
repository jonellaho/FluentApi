using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent.Property.Model
{
	public class Track
	{
		public Track()
		{
			Detail = new Detail();
		}

		// Primary Key
		[Key]
		[Column(Order = 1)]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int TrackId { get; set; }
		[Key]
		[Column(Order = 2)]
		public int AlbumId { get; set; }

		// Properties
		public string Name { get; set; }

		// Relationships
		public virtual Album Album { get; set; }

		public Detail Detail { get; set; }
	}
}
