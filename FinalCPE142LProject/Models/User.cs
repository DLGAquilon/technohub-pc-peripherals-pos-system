using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCPE142LProject.Models
{
    public class User
    {
        public int userID;
        public string fName = "";
        public string lName = "";
        public string address = "";
        public string phone = "";
        public string username = "";
        public string pass = "";

        public static string currentUsername { get; set; }
    }
}
