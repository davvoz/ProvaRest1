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
        [Route("students")]
        public HttpResponseMessage GetStudents()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        [Route("age")]
        public HttpResponseMessage GetMessage(String birthday)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Models.Student.CalcolaAge(birthday));
            return response;
        }

        [Route("addStudent")]
        public HttpResponseMessage PostAddStudent(Student student)
        {
            students.Add(student);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        [Route("getStudent")]
        public HttpResponseMessage GetStudent(String name)
        {
            var query = from Student s in students
                        where s.Firstname == name
                        select s;
            
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK,query);
            return response;
        }
        [Route("faseUno")]
        public object GetFiboQuestion(int number)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Common.SearchIntoFibonacciSequence(number));
            return response;
        }
    }
}
