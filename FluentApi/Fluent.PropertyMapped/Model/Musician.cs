namespace Fluent.PropertyMapped.Model
{
	public class Musician
	{
		// Primary Key
		// The Entity Framework convention for primary keys is:
		//   1 - Your class defines a property whose name is “ID” or “Id”
		//   2 - A class name followed by “ID” or “Id”

		//public int Id { get; set; }
		//public int MusicianId { get; set; }
		public int MusicianKey { get; set; }

		// Properties
		public string Name { get; set; }

		// Relationships
		public int BandId { get; set; }
		public virtual Band Band { get; set; }
	}
}
