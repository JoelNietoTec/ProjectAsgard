using System.Web;
using System.Web.Optimization;

namespace ProjectWebClient
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/WinJS/js/base.min.js",
                      "~/WinJS/js/ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                     "~/Scripts/angular.min.js",
                     "~/Scripts/angular-route.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/WinJS/Light").Include(
                      "~/WinJS/css/ui-light.css"));

            bundles.Add(new StyleBundle("~/WinJS/Dark").Include(
                      "~/WinJS/css-light.css"));
        }
    }
}
