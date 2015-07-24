using System.Web;
using System.Web.Optimization;

namespace AECHackathon
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/activePLAN").Include(
           "~/Scripts/jquery-2.1.4.min.js",
           "~/Scripts/bootstrap.min.js",
           "~/Scripts/defaults.js",
           "~/Scripts/apfunctions.js",
           "~/Scripts/respond.js",
           "~/Scripts/plugins.min.js",
            "~/Scripts/jquery.redirect.js",
            "~/plugins/bootbox/bootbox.min.js"

           ));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Scripts/bootstrap-table.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                "~/plugins/datatables/media/css/dataTables.bootstrap.css",
                "~/plugins/datatables/extensions/Responsive/css/dataTables.responsive.css"
               ));

            bundles.Add(new ScriptBundle("~/bundles/AECHackathon").Include(
                "~/Scripts/jquery-2.1.4.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/nifty.min.js",
                "~/Scripts/jquery.redirect.js",
                "~/Scripts/nifty-demo.min.js",
                "~/plugins/bootstrap-table/bootstrap-table.min.js",
                "~/plugins/bootbox/bootbox.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/AECHackathon").Include(
               "~/Content/bootstrap.min.css",
               "~/Content/font-awesome.css",
               "~/Content/nifty.min.css",
               "~/plugins/bootstrap-table/bootstrap-table.min.css",
               "~/Content/nifty-demo.min.css"
               ));

            bundles.Add(new StyleBundle("~/Content/activePLAN").Include(
               "~/Content/bootstrap.min.css",
               "~/Content/apFonts.css",
               "~/Content/plugins.min.css",
               "~/Content/font-awesome.css",
               "~/Content/nifty.min.css",
               "~/Content/nifty-demo.min.css"
               ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            "~/Content/themes/base/jquery.ui.core.css",
            "~/Content/themes/base/jquery.ui.resizable.css",
            "~/Content/themes/base/jquery.ui.selectable.css",
            "~/Content/themes/base/jquery.ui.accordion.css",
            "~/Content/themes/base/jquery.ui.autocomplete.css",
            "~/Content/themes/base/jquery.ui.button.css",
            "~/Content/themes/base/jquery.ui.dialog.css",
            "~/Content/themes/base/jquery.ui.slider.css",
            "~/Content/themes/base/jquery.ui.tabs.css",
            "~/Content/themes/base/jquery.ui.datepicker.css",
            "~/Content/themes/base/jquery.ui.progressbar.css",
            "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}

