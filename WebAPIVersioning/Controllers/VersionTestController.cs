using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIVersioning.Controllers
{
    public class VersionTestController : ApiController
    {
        [VersionedRoute("api/versiontest/a", 1)]
        [HttpGet]
        public IHttpActionResult GetA()
        {
            return  SetVersionOk(new string[] { "returning A Version 1" });
        }

        [VersionedRoute("api/versiontest/b", 1)]
        [HttpGet]
        public IHttpActionResult GetB()
        {
            return SetVersionOk(new string[] { "returning B Version 1" });
        }

        [VersionedRoute("api/versiontest/{id}/c", 1)]
        [HttpGet]
        public IHttpActionResult GetC(int id)
        {
            return SetVersionOk(new List<string> { "returning C Version 1, id:" + id });
        }

        private IHttpActionResult SetVersionOk(object body)
        {
            return new SetVersionInResponseHeader<object>(Request, "1", body);
        }
    }
}
