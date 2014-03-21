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
        public IEnumerable<string> GetA()
        {
            return new string[] { "returning A Version 1" };
        }

        [VersionedRoute("api/versiontest/b", 1)]
        [HttpGet]
        public IEnumerable<string> GetB()
        {
            return new string[] { "returning B Version 1" };
        }

        [VersionedRoute("api/versiontest/{id}/c", 1)]
        [HttpGet]
        public IEnumerable<string> GetC(int id)
        {
            return new string[] { "returning C Version 1, id:" + id };
        } 
    }
}
