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
    public class LoginFormModel : PageModel
    {

        [BindProperty]
        public LoginModel Login { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            //declare varibles
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, outputString = "";
            bool exists = false;


            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString =
            "Data Source=LAPTOP-PHB962HE;Initial Catalog=DB_FitBit;User id= admin;Password=admin123t;Integrated Security=True";


            cnn.Open();

            //data fetching
            sql = "SELECT Username FROM USERS WHERE Username = '"+ Login.Username +"' AND Password = '"+Login.Password+"' ";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

                 while (dataReader.Read())
                 {
                     outputString = outputString + dataReader.GetValue(0); // getValue(0) pobiera całą linie name
                 }
                 
                 if (String.IsNullOrEmpty(outputString))
                 {
                    return Page();
                 }

            cnn.Close();


            return RedirectToPage("/Index");
        }

       
        
    }
}