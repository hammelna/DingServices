using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DingServices.Controllers
{
    public class DingController : ApiController
    {
        public DingController()
        {

        }

        [HttpGet]
        public HttpResponseMessage GetDings([FromBody] Interfaces.IUserProfile primaryProfile)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            return response;
        }

        [HttpGet]
        public HttpResponseMessage SendDing([FromUri] string receivingUserName, [FromBody] Interfaces.IUserProfile sender)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            return response;
        }

        [HttpGet]
        public HttpResponseMessage AcceptDing()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            return response;
        }
    }
}
