using Fluent.PropertyMapped.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Fluent.PropertyMapped
{
	public class PropertyMappedDbContext : DbContext
	{
		public PropertyMappedDbContext() : base("name=FluentPropertyMapped_Connection")
		{
		}

		public DbSet<Band> Bands { get; set; }
		public DbSet<Musician> Musicians { get; set; }
		public DbSet<Album> Albums { get; set; }
		public DbSet<Track> Tracks { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			// KEYS AND INDEXES //


			// Configure Primary Key:
			modelBuilder.Entity<Musician>()
				.HasKey(e => e.MusicianKey);


			// Switching off Identity for Numeric Primary Keys:
			modelBuilder.Entity<Track>()
				.Property(e => e.TrackId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


			// Configuring a Composite Primary Key:
			modelBuilder.Entity<Track>()
				.HasKey(e => new { e.AlbumId, e.TrackId });


			// Configuring an Index on a property:
			modelBuilder.Entity<Band>()
				.Property(p => p.Name)
				.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute()));




			// PROPERTY MAPPINGS //


			// Set column size to 50:
			modelBuilder.Entity<Band>()
				.Property(p => p.Name)
				.HasMaxLength(50);


			// Configure Column Name, Type, and Optimistic Concurrency Token for a property:
			modelBuilder.Entity<Album>()
				.Property(p => p.ReleaseDate)
				.HasColumnName("Released")
				.HasColumnType("datetime2")
				.IsConcurrencyToken();


			// Set column size to 10 and change datatype to nchar:
			//   - IsFixedLength() changes datatype from nvarchar to nchar
			modelBuilder.Entity<Album>()
					.Property(p => p.Format)
					.HasMaxLength(3)
					.IsFixedLength();


			// Set property percision to decimal(2,2):
			modelBuilder.Entity<Album>()
				.Property(p => p.Length)
				.HasPrecision(4, 2);


			// Configure NotNull column for a property:
			modelBuilder.Entity<Album>()
				.Property(p => p.Studio)
				.IsRequired();


			// Configure Null column for a property:
			modelBuilder.Entity<Album>()
				.Property(p => p.SinglesReleased)
				.IsOptional();


			// Specifying Not to Map a CLR Property to a Column in the Database
			modelBuilder.Entity<Band>()
				.Ignore(t => t.NetWorth);


			// Configure a property for a Complex Type
			modelBuilder.Entity<Track>()
				.Property(t => t.Detail.Length)
				.IsOptional();




			// TYPE MAPPINGS //


			// Specifying That a Class Is a Complex Type
			modelBuilder.ComplexType<Detail>();



			// Remove Pluralization
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}
	}
}
