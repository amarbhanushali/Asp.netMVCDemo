using System.Web;
using System.Web.Optimization;

namespace CashBack
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/vendor/animsition/js/animsition.min.js",
                      "~/Scripts/popper.min.js",
                      "~/Scripts/mdb.min.js",
                      "~/Scripts/vendor/select2/select2.min.js",
                      "~/Scripts/vendor/daterangepicker/moment.min.js",
                      "~/Scripts/vendor/daterangepicker/daterangepicker.js",
                      "~/Scripts/vendor/countdowntime/countdowntime.js",
                      "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/mdb.min.css",
                       "~/Content/css/mdb-plugins-gathered.min.css",
                      
                      "~/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/fonts/Linearicons-Free-v1vendor/daterangepicker/moment.min.js0.0/icon-font.min.css",
                      "~/Scripts/vendor/animate/animate.css",
                      "~/Scripts/vendor/css-hamburgers/hamburgers.min.css",
                      "~/Scripts/vendor/animsition/css/animsition.min.css",
                      "~/Scripts/vendor/select2/select2.min.css",
                      "~/Scripts/vendor/daterangepicker/daterangepicker.css",
                      "~/Content/css/util.css",
                      "~/Content/css/main.css"));
        }
    }
}
