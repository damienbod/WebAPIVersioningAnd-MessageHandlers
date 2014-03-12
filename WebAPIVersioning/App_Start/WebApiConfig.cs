using System.Web.Http;

namespace WebAPIVersioning
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/veryold",
                defaults: null,
                constraints: null,
                handler: new VersioningHandlerReturn()
                );

            config.MessageHandlers.Add(new VersioningHandler());
        }
    }
}
