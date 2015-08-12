using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DingServices.Controllers
{
    public class UserLocationController : ApiController
    {
        public UserLocationController()
        {

        }

        [HttpPut]
        public HttpResponseMessage UpdateLocation([FromUri]double latitude, [FromUri] double longitude)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            return response;
        }

        [HttpGet]
        public HttpResponseMessage GetLocation([FromBody]Interfaces.IUserProfile profile)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            return response;
        }
    }
}
