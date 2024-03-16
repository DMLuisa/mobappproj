using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Models
{
    public class Users
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool isLibrarian { get; set; }

        public Users() 
        {
            firstName = "";
            lastName = "";
            email = "";
            password = "";
            isLibrarian = false;
        }
    }
}
