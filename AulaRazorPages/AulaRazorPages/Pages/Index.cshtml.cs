using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulaRazorPages.Pages
{
    public class IndexModel : PageModel
    {

        public string? Title { get; set; }
        public void OnGet()// m�todo chamado quando a razorPage recebe uma requisi��o
        {
            Title = "My First APP from IndexModel";
        }
    }
}
