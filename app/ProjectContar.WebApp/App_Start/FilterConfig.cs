using System.Web.Mvc;

namespace ProjectContar.WebApp
{
    /// <summary>
    /// Filters to Use in sistem.
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Register filters to use in system.
        /// </summary>
        /// <param name="filters">Filters in system.</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}