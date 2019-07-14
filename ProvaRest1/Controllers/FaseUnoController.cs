using ProvaRest1.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProvaRest1.Controllers
{
    public class FaseUnoController : ApiController
    {
        //GET con parametro . Quale è il primo numero della sequenza di fibonacci ad avere tot cifre?
        /// <summary>
        ///  Quale è il primo numero della sequenza di fibonacci ad avere tot cifre?
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [Route("faseUno")]
        public object GetFiboQuestion(int number)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Common.SearchFirstOccurencyTotCharFibonacci(number));
            return response;
        }
    }
}
