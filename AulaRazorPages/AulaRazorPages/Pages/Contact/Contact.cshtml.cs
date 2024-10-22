using AulaRazorPages.Records;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AulaRazorPages.Pages.Contact
{
    public class ContactModel : PageModel
    {
        // Utilizando este BindProperty, n�o precisa passar o ContactFormModel como paar�metro [FromForm] no m�todo post
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
                // Neste caso, n�o precisa da instru��o abaixo, pois o BindProperty j� est� 'bindando' o ContactForm vindos l� do form do front
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
