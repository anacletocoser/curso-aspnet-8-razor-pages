using AulaRazorPages.Records;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AulaRazorPages.Pages.Contact
{
    public class ContactModel : PageModel
    {
        // Utilizando este BindProperty, não precisa passar o ContactFormModel como paarâmetro [FromForm] no método post
        [BindProperty]
        public ContactFormModel? ContactForm { get; set; }

        [ViewData]
        public string MessageSuccess { get; set; }
        public void OnGet()
        {
            ContactForm = new ContactFormModel();
        }

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                // Neste caso, não precisa da instrução abaixo, pois o BindProperty já está 'bindando' o ContactForm vindos lá do form do front
                //ContactForm = formModel; 
                return Page();
            }

            // send email
            // save on database
            // do something else
            MessageSuccess = "Contact Saved!";

            return Page();
        }
    }
}
