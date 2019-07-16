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
            //assumoo che la variabile birthday mi venga passata in questo formato ddMMYYYY
            return Common.CalcolaAge(Birthday);
        }
        public static double Avg_grade(string Grades)
        {
            //Assumo che i grades siano voti salvati su una stringa e separati tramite un separatore tipo '7;4;9;10;8;6' il separatore deve essere ';'
            //uso static per poter utilizzare il metodo in altri contesti (servizio rest) senza dover dichiarare l'oggetto
            string[] gradesList = Grades.Split(';');
            double sommatoria = 0;
            double numeroValutazioni = 0;
            foreach (string grade in gradesList) {
                sommatoria += System.Convert.ToInt32(grade);
                numeroValutazioni++;
            }
            return sommatoria/numeroValutazioni;
        }
    }
}