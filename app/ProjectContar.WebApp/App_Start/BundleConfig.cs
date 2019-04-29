using System.Web.Optimization;

namespace ProjectContar.WebApp
{
    /// <summary>
    /// Bundle configuration.
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Register bundles to use in system.
        /// </summary>
        /// <param name="bundles">Bundles in sistem.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.maskMoney.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                       "~/Scripts/materialize.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/datepicker/i18n").Include(
                       "~/Scripts/i18n/datepicker-pt-br.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/FontAwesome").Include(
                    "~/Content/FontAwesome/all.css"));

            bundles.Add(new StyleBundle("~/Content/materialize").Include(
                   "~/Content/materialize.css"));

            // BundleTable.EnableOptimizations = true;
        }
    }
}