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
        public IEnumerable<string> GetA()
        {
            return new string[] { "returning A Version 2" };
        }

        [HttpGet]
        [VersionedRoute("api/versiontest/b", 2)]
        public IEnumerable<string> GetB()
        {
            return new string[] { "returning B Version 2" };
        }

        [VersionedRoute("api/versiontest/{id}/c", 2)]
        [HttpGet]
        public IEnumerable<string> GetC(int id)
        {
            return new string[] { "returning C Version 2, id:" + id };
        } 
    }
}
