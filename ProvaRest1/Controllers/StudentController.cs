using ProvaRest1.Biz;
using ProvaRest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProvaRest1.Controllers
{  
    public class StudentController : ApiController
    {
        public static List<Student> students = new List<Student>();

        //GET ritorna lista di students
        [Route("students")]
        public HttpResponseMessage GetStudents()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }
        //POST aggiungere uno student alla lista
        [Route("addStudent")]
        public HttpResponseMessage PostAddStudent(Student student)
        {
            students.Add(student);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }
        //GET con parametro.Ritorna uno student in base al nome
        [Route("getStudent")]
        public HttpResponseMessage GetStudent(String name)
        {
            var query = from Student s in students
                        where s.Firstname == name
                        select s;
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, query);
            return response;
        }
        //GET con parametro.Ritorna l'età in base alla data di nascita
      
        [Route("age")]
        public HttpResponseMessage GetMessage(String birthday)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Common.CalcolaAge(birthday));
            return response;
        }

    }
}
