namespace Fluent.Property.Migrations
{
	using Model;
	using System;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<PropertyDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(PropertyDbContext context)
		{
			context.Bands.AddOrUpdate(
			  p => p.BandId,
			  new Band { BandId = 1, Name = "Guns N' Roses" },
			  new Band { BandId = 2, Name = "U2" },
			  new Band { BandId = 3, Name = "Pink Floyd" }
			);

			context.Musicians.AddOrUpdate(
			  p => p.MusicianKey,
			  new Musician { MusicianKey = 1, BandId = 1, Name = "Axl Rose" },
			  new Musician { MusicianKey = 2, BandId = 1, Name = "Slash" },
			  new Musician { MusicianKey = 3, BandId = 1, Name = "Izzy Stradlin" },
			  new Musician { MusicianKey = 4, BandId = 1, Name = "Duff McKagan" },
			  new Musician { MusicianKey = 5, BandId = 1, Name = "Steven Adler" },
			  new Musician { MusicianKey = 6, BandId = 2, Name = "Bono" },
			  new Musician { MusicianKey = 7, BandId = 2, Name = "The Edge" },
			  new Musician { MusicianKey = 8, BandId = 2, Name = "Adam Clayton" },
			  new Musician { MusicianKey = 9, BandId = 2, Name = "Larry Mullen, Jr." },
			  new Musician { MusicianKey = 10, BandId = 3, Name = "David Gilmour" },
			  new Musician { MusicianKey = 11, BandId = 3, Name = "Nick Mason" },
			  new Musician { MusicianKey = 12, BandId = 3, Name = "Richard Wright" },
			  new Musician { MusicianKey = 13, BandId = 3, Name = "Roger Waters" }
			);

			context.Albums.AddOrUpdate(
			  p => p.AlbumId,
			  new Album
			  {
				  AlbumId = 1,
				  BandId = 1,
				  ReleaseDate = DateTime.Parse("1987-07-21"),
				  Format = "AAD",
				  Length = 53.51m,
				  SinglesReleased = 5,
				  Studio = "The Record Plant, Los Angeles",
				  Name = "Appetite for Destruction"
			  },
			  new Album
			  {
				  AlbumId = 2,
				  BandId = 2,
				  ReleaseDate = DateTime.Parse("1991-11-18"),
				  Format = "DDD",
				  Length = 55.27m,
				  SinglesReleased = 5,
				  Studio = "Windmill Lane Studios, Dublin",
				  Name = "Achtung Baby"
			  },
			  new Album
			  {
				  AlbumId = 3,
				  BandId = 2,
				  ReleaseDate = DateTime.Parse("1997-03-03"),
				  Format = "DDD",
				  Length = 60.09m,
				  SinglesReleased = 6,
				  Studio = "Windmill Lane Studios, Dublin",
				  Name = "Pop"
			  },
			  new Album
			  {
				  AlbumId = 4,
				  BandId = 3,
				  ReleaseDate = DateTime.Parse("1973-03-01"),
				  Format = "AAD",
				  Length = 42.49m,
				  Studio = "Abbey Road Studios, London",
				  Name = "The Dark Side of the Moon"
			  }
			);

			context.Tracks.AddOrUpdate(
			  p => p.TrackId,
			  new Track { AlbumId = 1, TrackId = 1, Name = "Welcome to the Jungle" },
			  new Track { AlbumId = 1, TrackId = 2, Name = "It's So Easy" },
			  new Track { AlbumId = 1, TrackId = 3, Name = "Nightrain" },
			  new Track { AlbumId = 1, TrackId = 4, Name = "Out ta Get Me" },
			  new Track { AlbumId = 1, TrackId = 5, Name = "Mr. Brownstone" },
			  new Track { AlbumId = 1, TrackId = 6, Name = "Paradise City" },
			  new Track { AlbumId = 1, TrackId = 7, Name = "My Michelle" },
			  new Track { AlbumId = 1, TrackId = 8, Name = "Think About You" },
			  new Track { AlbumId = 1, TrackId = 9, Name = "Sweet Child o' Mine" },
			  new Track { AlbumId = 1, TrackId = 10, Name = "You're Crazy" },
			  new Track { AlbumId = 1, TrackId = 11, Name = "Anything Goes" },
			  new Track { AlbumId = 1, TrackId = 12, Name = "Rocket Queen" },
			  new Track { AlbumId = 2, TrackId = 1, Name = "Zoo Station" },
			  new Track { AlbumId = 2, TrackId = 2, Name = "Even Better Than the Real Thing" },
			  new Track { AlbumId = 2, TrackId = 3, Name = "One" },
			  new Track { AlbumId = 2, TrackId = 4, Name = "Until the End of the World" },
			  new Track { AlbumId = 2, TrackId = 5, Name = "Who's Gonna Ride Your Wild Horses" },
			  new Track { AlbumId = 2, TrackId = 6, Name = "So Cruel" },
			  new Track { AlbumId = 2, TrackId = 7, Name = "The Fly" },
			  new Track { AlbumId = 2, TrackId = 8, Name = "Mysterious Ways" },
			  new Track { AlbumId = 2, TrackId = 9, Name = "Tryin' to Throw Your Arms Around the World" },
			  new Track { AlbumId = 2, TrackId = 10, Name = "Ultraviolet (Light My Way)" },
			  new Track { AlbumId = 2, TrackId = 11, Name = "Acrobat" },
			  new Track { AlbumId = 2, TrackId = 12, Name = "Love Is Blindness" },
			  new Track { AlbumId = 3, TrackId = 1, Name = "Discothèque" },
			  new Track { AlbumId = 3, TrackId = 2, Name = "Do You Feel Love" },
			  new Track { AlbumId = 3, TrackId = 3, Name = "Mofo" },
			  new Track { AlbumId = 3, TrackId = 4, Name = "If God Will Send His Angels" },
			  new Track { AlbumId = 3, TrackId = 5, Name = "Staring at the Sun" },
			  new Track { AlbumId = 3, TrackId = 6, Name = "Last Night on Earth" },
			  new Track { AlbumId = 3, TrackId = 7, Name = "Gone" },
			  new Track { AlbumId = 3, TrackId = 8, Name = "Miami" },
			  new Track { AlbumId = 3, TrackId = 9, Name = "The Playboy Mansion" },
			  new Track { AlbumId = 3, TrackId = 10, Name = "If You Wear That Velvet Dress" },
			  new Track { AlbumId = 3, TrackId = 11, Name = "Please" },
			  new Track { AlbumId = 3, TrackId = 12, Name = "Wake Up Dead Man" },
			  new Track { AlbumId = 4, TrackId = 1, Name = "Speak to Me" },
			  new Track { AlbumId = 4, TrackId = 2, Name = "Breathe" },
			  new Track { AlbumId = 4, TrackId = 3, Name = "On the Run" },
			  new Track { AlbumId = 4, TrackId = 4, Name = "Time" },
			  new Track { AlbumId = 4, TrackId = 5, Name = "The Great Gig in the Sky" },
			  new Track { AlbumId = 4, TrackId = 6, Name = "Money" },
			  new Track { AlbumId = 4, TrackId = 7, Name = "Us and Them" },
			  new Track { AlbumId = 4, TrackId = 8, Name = "Any Colour You Like" },
			  new Track { AlbumId = 4, TrackId = 9, Name = "Brain Damage" },
			  new Track { AlbumId = 4, TrackId = 10, Name = "Eclipse" }
			);
		}
	}
}
