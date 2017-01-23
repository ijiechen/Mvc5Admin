using System.Web;
using System.Web.Optimization;

namespace Mvc5Admin.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            
            bundles.Add(new ScriptBundle("~/bundles/matchMedia").Include(
                    "~/Scripts/matchMedia.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //"~/Scripts/jquery.min.js"));
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"
                     // ,"~/Scripts/respond.js"
                      ));
            
            bundles.Add(new ScriptBundle("~/bundles/storage").Include(
                    "~/Scripts/jquery.storageapi.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryEasing").Include(
                    "~/Scripts/jquery.easing.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/animo").Include(
                    "~/Scripts/animo.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/slimscroll").Include(
                    "~/Scripts/jquery.slimscroll.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/screenfull").Include(
                    "~/Scripts/screenfull.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/localize").Include(
                    "~/Scripts/jquery.localize.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/demoRTL").Include(
                    "~/Scripts/demoRTL.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));



            bundles.Add(new ScriptBundle("~/bundles/Angle").Include(
                    "~/Scripts/Angle.min.js"));
            

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      // "~/Content/app.css",
                      "~/Content/app/css/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/app").Include(
                      // "~/Content/app.css",
                      "~/Content/app.css"));
            bundles.Add(new StyleBundle("~/Content/mvc-override").Include(
                      "~/Content/mvc-override.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                      "~/Content/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/Content/simpleLineIcons").Include(
                      "~/Content/simple-Line-Icons.css"));
            bundles.Add(new StyleBundle("~/Content/animatecss").Include(
                      "~/Content/animate.min.css"));
            bundles.Add(new StyleBundle("~/Content/whirl").Include(
                      "~/Content/whirl.min.css"));
        }
    }
}
