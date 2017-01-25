using System.Web;
using System.Web.Optimization;
using Microsoft.Ajax.Utilities;

namespace Mvc5Admin.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;

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

            bundles.Add(new ScriptBundle("~/bundles/Parsley").Include(
                        "~/Scripts/Parsley/dist/Parsley.min.js"
                        , "~/Scripts/Parsley/dist/i18n/zh_cn.extra.js"
                        , "~/Scripts/Parsley/dist/i18n/zh_cn.js"));



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

            //Forms
            bundles.Add(new StyleBundle("~/Content/tagsinputCss").Include(
                        "~/Scripts/bootstrap-tagsinput/dist/bootstrap-tagsinput.css"));
            bundles.Add(new ScriptBundle("~/bundles/tagsinput").Include(
                        "~/Scripts/bootstrap-tagsinput/dist/bootstrap-tagsinput.min.js"));

            bundles.Add(new StyleBundle("~/Content/sliderCtrlCss").Include(
                        "~/Scripts/bootstrap-slider/dist/css/bootstrap-slider.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/sliderCtrl").Include(
                        "~/Scripts/bootstrap-slider/dist/bootstrap-slider.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                        "~/Scripts/moment/min/moment.min.js"));

            bundles.Add(new StyleBundle("~/Content/datetimepickerCss").Include(
                      "~/Scripts/bootstrap-datetimepicker/build/css/bootstrap-datetimepicker.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/datetimepicker").Include(
                        "~/Scripts/bootstrap-datetimepicker/build/js/bootstrap-datetimepicker.min.js"));

            bundles.Add(new StyleBundle("~/Content/colorPickerCss").Include(
                        "~/Scripts/colorpicker/css/colorpicker.css"));
            bundles.Add(new ScriptBundle("~/bundles/colorPicker").Include(
                        "~/Scripts/colorpicker/js/bootstrap-colorpicker.js"));

            bundles.Add(new StyleBundle("~/Content/select2Css").Include(
                        "~/Scripts/select2-4.0.3/dist/css/select2.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/select2").Include(
                        "~/Scripts/select2-4.0.3/dist/js/select2.min.js"));

            bundles.Add(new StyleBundle("~/Content/chosenCss").Include(
                        "~/Scripts/chosen_v1.6.2/chosen.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/chosen").Include(
                        "~/Scripts/chosen_v1.6.2/chosen.jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/inputmask").Include(
                        "~/Scripts/Inputmask/dist/min/jquery.inputmask.bundle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/filestyle").Include(
                        "~/Scripts/bootstrap-filestyle-1.2.1/src/bootstrap-filestyle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/skycons").Include(
                        "~/Scripts/skycons/skycons.js"));

            bundles.Add(new StyleBundle("~/Content/weatherIcons").Include(
                        "~/Scripts/weather-icons/css/weather-icons.min.css"
                        , "~/Scripts/weather-icons/css/weather-icons-wind.min.css"));
            
            bundles.Add(new StyleBundle("~/Content/loaders").Include(
                        "~/Scripts/loaders/loaders.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/loaders").Include(
                        "~/Scripts/loaders/loaders.css.js"));

            bundles.Add(new StyleBundle("~/Content/wysiwygCss").Include(
                      "~/Scripts/bootstrap3-wysiwyg/dist/bootstrap3-wysihtml5.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/wysiwyg").Include(
                        "~/Scripts/bootstrap3-wysiwyg/dist/bootstrap3-wysihtml5.min.js"));

            bundles.Add(new StyleBundle("~/Content/sweetalert").Include(
                      "~/Scripts/sweetalert/dist/sweetalert.css"));
            bundles.Add(new ScriptBundle("~/bundles/sweetalert").Include(
                        "~/Scripts/sweetalert/dist/sweetalert.min.js"));

            bundles.Add(new StyleBundle("~/Content/nprogress").Include(
                      "~/Scripts/nprogress/custom.css"
                      ,"~/Scripts/nprogress/nprogress.css"));
            bundles.Add(new ScriptBundle("~/bundles/nprogress").Include(
                        "~/Scripts/nprogress/nprogress.js"));

            bundles.Add(new ScriptBundle("~/bundles/canvasbg").Include(
                        "~/Scripts/canvasbg/canvasbg.js"));

            bundles.Add(new StyleBundle("~/Content/fileupload").Include(
                      "~/Scripts/jQuery-File-Upload/css/jquery.fileupload.css"
                      , "~/Scripts/jQuery-File-Upload/css/jquery.fileupload.css"));
            bundles.Add(new ScriptBundle("~/bundles/fileupload").Include(
                         "~/Scripts/jQuery-File-Upload/js/jquery.iframe-transport.js"
                       , "~/Scripts/jQuery-File-Upload/js/jquery.fileupload.js"));

        }
    }
}
