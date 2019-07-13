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
        [Route("age")]
        public HttpResponseMessage GetMessage(String birthday)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Models.Student.CalcolaAge(birthday));
            return response;
        }
        [Route("age")]
        public HttpResponseMessage GetMessage1(String birthday)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Models.Student.CalcolaAge(birthday));
            return response;
        }
    }
}
