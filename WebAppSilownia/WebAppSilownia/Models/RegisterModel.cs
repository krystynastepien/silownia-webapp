using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSilownia.Models
{
    public class RegisterModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }



        public int SaveDetails()
        {
            var con = new SqlConnection(@"Data Source = LAPTOP - PHB962HE\\ONPRO; Initial Catalog = DB_FitBit; Integrated Security = True;");
            string query = "INSERT INTO USERS(FirstName, LastName, Email, Username, Password) values ('" + FirstName + "','" + LastName + "','" + Email  + "','" + Username + "','" + Password + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }


    }
}
