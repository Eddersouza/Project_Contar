using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectContar.WebApp
{
    /// <summary>
    /// Route configuration.
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Register routes to use in sistem.
        /// </summary>
        /// <param name="routes">Routes in systems.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}