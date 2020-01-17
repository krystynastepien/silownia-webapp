using System;
using System.Collections.Generic;

namespace WebAppSilownia.Models
{
    public partial class Users
    {
        public int UId { get; set; }
        public string UName { get; set; }
        public string ULastName { get; set; }
        public string UEmail { get; set; }
        public string UUsername { get; set; }
        public string UPassword { get; set; }
    }
}
