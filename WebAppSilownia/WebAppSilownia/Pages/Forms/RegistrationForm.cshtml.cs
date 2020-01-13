using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppSilownia.Models;

namespace WebAppSilownia
{
    public class RegistrationFormModel : PageModel
    {
        [BindProperty]
        public RegisterModel Register { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            //TODO: add validation of whole form
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            //TODO: save to database
            return RedirectToPage("/Index");
        }
    }
}