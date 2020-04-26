using System;
using System.Linq;
using System.Data.Entity;
using Fluent.PropertyMapped;

namespace Fluent.ConsoleApp.Commands
{
	public static class PropertiesFluentAPI
	{
		public static void Get()
		{
			Console.WriteLine();
			using (var db = new PropertyMappedDbContext())
			{
				var bandsWithAlbums = db.Bands
					.Include(i => i.Musicians)
					.Include(i => i.Albums)
					.Include(i => i.Albums.Select(j => j.Tracks));

				foreach (var band in bandsWithAlbums)
				{
					Console.WriteLine(band.Name);
					Console.WriteLine();
					Console.WriteLine(" -Members:");
					Console.WriteLine();

					foreach (var musician in band.Musicians)
					{
						Console.WriteLine("    " + musician.Name);
					}

					Console.WriteLine();
					Console.WriteLine(" -Albums:");
					Console.WriteLine();

					foreach (var album in band.Albums)
					{
						Console.WriteLine("    " + album.Name + " - Released " + album.ReleaseDate.ToString("d") + " - Recorded at " + album.Studio + " - Running Time " + album.Length);

						foreach (var track in album.Tracks)
						{
							Console.WriteLine("    " + track.TrackId + " " + track.Name);
						}

						Console.WriteLine();
					}
					Console.WriteLine();
				}
			}
		}
	}
}
