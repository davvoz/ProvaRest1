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
        public List<Student> students;
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
    }
}
