using System.Web;
using System.Web.Optimization;

namespace TyresStore
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/tools/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/tools/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/tools/bootstrap.js",
                       "~/Scripts/tools/jquery.colorbox-min.js",
                      "~/Scripts/tools/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/myscript").Include(
  
                     "~/Scripts/client/basketmodel.js",
                     "~/Scripts/client/mainmodel.js",
                     "~/Scripts/client/handlers.js"));

            bundles.Add(new StyleBundle("~/bundles/boostrap").Include(
                    "~/Scripts/toolscss/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/material").Include(
                     "~/Scripts/material/mdb.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      
                      "~/Content/toolscss/colorbox.css",
                      "~/Content/myStyle.css"));
            bundles.Add(new StyleBundle("~/Content/material").Include(
                     "~/Content/Material/mdb.css"));

        }
    }
}
