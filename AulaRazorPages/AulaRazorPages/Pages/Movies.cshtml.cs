using AulaRazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulaRazorPages.Pages
{
    public class MoviesModel(MoviesContext moviesContext) : PageModel
    {
        public ICollection<Movie> Movies { get; private set; }
        public void OnGet()
        {
            Movies = moviesContext.Movies.ToList();
        }
    }
}
