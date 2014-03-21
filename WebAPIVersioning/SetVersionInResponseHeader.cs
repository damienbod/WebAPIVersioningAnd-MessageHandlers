using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebAPIVersioning
{
    public class SetVersionInResponseHeader<T> : IHttpActionResult where T : class
    {
        private HttpRequestMessage _request;
        private T _body;
        private string _version;

        public SetVersionInResponseHeader(HttpRequestMessage request, string version, T body)
        {
            _request = request;
            _version = version;
            _body = body;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = _request.CreateResponse(_body);
            response.Headers.Add("api-version", _version);
            return Task.FromResult(response);
        }
    }
}