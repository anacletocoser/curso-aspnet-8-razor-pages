using Microsoft.EntityFrameworkCore;
using Slugify;

namespace AulaRazorPages.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() 
        {
            this.Database.EnsureCreated();
        }
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var slugify = new SlugHelper();

            string[] names = [
                "O poderoso Chefão",
                "O senhor dos ANéis: O retorno do Rei",
                "Interestelar",
                "O silencio dos inocentes"
                ];

            int counter = 1;
            var movies = new List<Movie>();
            foreach(var name in names)
            {
                movies.Add(new Movie
                {
                    Id = counter,
                    Name = name,
                    Permalink = slugify.GenerateSlug(name)
                });
                counter++;
            }
            modelBuilder
                .Entity<Movie>()
                .HasData(movies);
        }
    }
}
