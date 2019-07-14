using ProvaRest1.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaRest1.Models
{
    public class Student
    {
       
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Birthdate { get; set; }
        public string Grades { get; set; }
        public int CalcolaAge(string Birthday)
        {
            return Common.CalcolaAge(Birthday);
        }
        public void Avg_grade() {
            //TODO : cosa dovrebbe fare?
        }
    }
}