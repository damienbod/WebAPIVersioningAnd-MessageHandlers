using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIVersioning.Controllers
{
    [RoutePrefix("api/v2/myservice")]
    public class MyServiceV2Controller : ApiController
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "V2-1", "V2-2" };
        }
    }
}