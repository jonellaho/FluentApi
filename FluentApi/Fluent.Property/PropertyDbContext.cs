using Fluent.Property.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Fluent.Property
{
	public class PropertyDbContext : DbContext
	{
		public PropertyDbContext() : base("name=FluentProperty_Connection")
		{
		}

		public DbSet<Band> Bands { get; set; }
		public DbSet<Musician> Musicians { get; set; }
		public DbSet<Album> Albums { get; set; }
		public DbSet<Track> Tracks { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			// Remove Pluralization
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}
	}
}
