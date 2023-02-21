using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Module004HW5.Configurations;
using Module004HW5.Extensions;
using Module004HW5.Models;

namespace Module004HW5.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<ArtistSong> ArtistSongs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistSongConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.Seed();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile("configuration.json")
                .Build();
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(configuration["Path:ConnectionString"]!);
        }
    }
}
