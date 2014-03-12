using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIVersioning.Controllers
{
    [RoutePrefix("api/myservice")]
    public class MyServiceController : ApiController
    {
        // OLD methods still required for legacy clients. The client is informed with a 426 in a message handler but still receives content.
        [Route("")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "V1-1", "V1-2" };
        } 
    }
}
