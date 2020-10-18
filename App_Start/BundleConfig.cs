using System.Web;
using System.Web.Optimization;

namespace Ateshgah_Insurance_Project
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
             "~/Scripts/jquery-3.0.0.min.js",
             "~/Scripts/jquery.unobtrusive-ajax.min.js",
             "~/Scripts/bootstrap.min.js",
             "~/Scripts/DataTables/jquery.dataTables.min.js",
             "~/Scripts/DataTables/dataTables.bootstrap.min.js",
             "~/Scripts/custom.js",
             "~/Scripts/bootbox.min.js"
             ));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/website.css",
                "~/Content/DataTables/css/dataTables.bootstrap.min.css"

                ));
        }
    }
}
