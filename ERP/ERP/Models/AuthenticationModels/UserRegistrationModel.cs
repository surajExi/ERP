using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanner.Models.AuthenticationModels
{
    public class UserRegistrationModel
    {
        public long UserID { get; set; }
        public string User_Name { get; set; }
        public string User_First_Name { get; set; }
        public string User_Last_Name { get; set; }
        public int User_Age { get; set; }
        public DateTime User_Dob { get; set; }
    }
}