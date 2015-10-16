using MVCSendGripJenkinsProDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCSendGripJenkinsProDev.Controllers
{
    public class SubmitController : ApiController
    {
        // GET api/submit
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/submit/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/submit
        public HttpResponseMessage Post([FromBody]Email value)
        {
            if (string.IsNullOrEmpty(value.Subject))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            if (string.IsNullOrEmpty(value.To))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            if (value == new Email())
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            if (value.DeliveryType != "Email")
            {
                return new HttpResponseMessage(HttpStatusCode.NotImplemented);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // PUT api/submit/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/submit/5
        //public void Delete(int id)
        //{
        //}
    }
}
