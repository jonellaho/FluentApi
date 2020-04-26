namespace Fluent.PropertyMapped.Model
{
	public class Track
	{
		public Track()
		{
			Detail = new Detail();
		}

		// Primary Key
		public int TrackId { get; set; }
		public int AlbumId { get; set; }

		// Properties
		public string Name { get; set; }

		// Relationships
		public virtual Album Album { get; set; }

		public Detail Detail { get; set; }
	}
}
