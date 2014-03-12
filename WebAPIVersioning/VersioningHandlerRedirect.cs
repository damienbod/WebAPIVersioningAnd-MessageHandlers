using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPIVersioning
{

    public class VersioningHandlerRedirect : DelegatingHandler
    {
        // stop proccessing return directly to client
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var resp = new HttpResponseMessage(HttpStatusCode.UpgradeRequired)
            {
                ReasonPhrase = "Use /api/v2/myservice this is very old and not supported",
                Content = new StringContent("Use /api/v2/myservice this is very old and not supported")

            };
            throw new HttpResponseException(resp);

        }
    }
}