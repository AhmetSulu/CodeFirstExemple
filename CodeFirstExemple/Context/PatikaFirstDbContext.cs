using CodeFirstExemple.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace CodeFirstExemple.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        // Movie ve Game tablolarını temsil eden DbSet'ler
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        // Constructor to accept DbContextOptions
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {
        }

        // Veritabanı bağlantı ayarları
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
            // SQL Server'ı kullanarak veritabanı bağlantısı ayarlanıyor.
            // optionsBuilder.UseSqlServer(@"Server=Ahmet;Database=PatikaCodeFirstDb;Trusted_Connection=True;");
        //}
    }

}
