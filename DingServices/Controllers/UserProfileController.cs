using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DingServices.Controllers
{
    public class UserProfileController : ApiController
    {
        public UserProfileController()
        {

        }

        [HttpGet]
        public HttpResponseMessage GetUserProfile(string username)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            //need some connection to the database here to get the user based on name (possibly ID?)

            return response;
        }

        [HttpGet]
        public HttpResponseMessage GetUserProfiles()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            return response;
        }

        [HttpPost]
        public HttpResponseMessage CreateUserProfile([FromBody]Interfaces.IUserProfile profile)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);

            return response;
        }

        [HttpPut]
        public HttpResponseMessage UpdateUserProfile([FromBody]Interfaces.IUserProfile profile)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            return response;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteUserProfile([FromBody] Interfaces.IUserProfile profile)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            return response;
        }
    }
}
