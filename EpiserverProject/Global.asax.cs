using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace EpiserverProject
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(RegisterApi);
        }

        public static void RegisterApi(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        }

        protected override void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("RatingPlugin", "RatingPlugin/{action}", new { controller = "RatingPlugin", action = "Index" });
            base.RegisterRoutes(routes);
        }
    }
}