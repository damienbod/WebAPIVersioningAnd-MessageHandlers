using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIVersioning.Controllers
{
    public class VersionTestV2Controller : ApiController
    {
        [HttpGet]
        [VersionedRoute("api/versiontest/a", 2)]
        public IHttpActionResult GetA()
        {
            return SetVersionOk(new string[] { "returning A Version 2" });
        }

        [HttpGet]
        [VersionedRoute("api/versiontest/b", 2)]
        public IHttpActionResult GetB()
        {
            return SetVersionOk(new string[] { "returning B Version 2" });
        }

        [VersionedRoute("api/versiontest/{id}/c", 2)]
        [HttpGet]
        public IHttpActionResult GetC(int id)
        {
            return SetVersionOk(new string[] { "returning C Version 2, id:" + id });
        }

        private IHttpActionResult SetVersionOk(object body)
        {
            return new SetVersionInResponseHeader<object>(Request, "2", body);
        }
    }
}
