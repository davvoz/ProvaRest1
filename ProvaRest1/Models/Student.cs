using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaRest1.Models
{
    public class Student
    {
       
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Birthdate { get; set; }
        public String Grades { get; set; }
        public static int CalcolaAge(String Birthday)
        {
            
            DateTime today = DateTime.Today;
            DateTime birthday = DateTime.ParseExact(Birthday, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int age = today.Year - birthday.Year;

            if (birthday.Date > today.AddYears(-age))
                age--;

            return age;

        }

    }
}