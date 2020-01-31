using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
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
            //declare varibles
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, outputString = "";

            //TODO: add validation of whole form
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            // DB connection

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString =
            "Data Source=LAPTOP-PHB962HE;Initial Catalog=DB_FitBit;User id= admin;Password=admin123t;Integrated Security=True";


            cnn.Open();

            //data fetching
            sql = "INSERT INTO USERS(Name, LastName, Email, Username, Password) " + "VALUES ('"+Register.FirstName+ "', '" + Register.LastName+ "', '" + Register.Email + "', '" + Register.Username + "', '" + Register.Password + "')";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

           //     while (dataReader.Read())
             //   {
            //    outputString = outputString + dataReader.GetValue(0) + " " + dataReader.GetValue(1); // getValue(0) pobiera całą linie name

            //    }
                cnn.Close();
            
            return RedirectToPage("/Index");
        }


    }
}