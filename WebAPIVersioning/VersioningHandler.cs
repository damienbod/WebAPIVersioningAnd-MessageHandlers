using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPIVersioning
{
    public class VersioningHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            
            if (request.RequestUri.ToString().Contains("api/myservice"))
            {
                // Recieved request for old service implementation. Will return the object and send a 426
                response.StatusCode = HttpStatusCode.UpgradeRequired;
                response.Headers.Add("Location", "/api/v2/myservice");
            }

            return response;
        }
    }

}