using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppSilownia.Models;
using static WebAppSilownia.Models.ClassFitBit;


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

            RegisterModel Rmodel = new RegisterModel();
            Rmodel.FirstName = HttpContext.Request.Form["txtName"].ToString();
            Rmodel.LastName = HttpContext.Request.Form["txtLastName"].ToString();
            Rmodel.Email = HttpContext.Request.Form["txtEmail"].ToString();
            int result = Rmodel.SaveDetails();
            

            return RedirectToPage("/Index");
        }


    }
}