using System.Web.Http;

namespace TestWorkWebApi2._0
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}",
                defaults: new { action = "Get" }
            );

            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
