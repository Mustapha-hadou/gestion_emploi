using System.Web;
using System.Web.Optimization;

namespace miniPrpject_Asp
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            /*bundles.Add(new ScriptBundle("~/bundles/admin/bootstrap").Include(
                       "~/js/bootstrap.bundle.min.js"
                       , "~/js/dataTables.bootstrap5.min.js"
                       , "~/js/script.js",
                       "~/js/bootstrap.bundle.min.js.map"
                       ));*/
            bundles.Add(new ScriptBundle("~/bundles/admin/jquery").Include(
                     "~/Scripts/jquery-3.5.1.js",
                       "~/Scripts/jquery.dataTables.min.js",
                        "~/Scripts/bootstrap.bundle.min.js"
                       , "~/Scripts/dataTables.bootstrap5.min.js"
                     , "~/Scripts/script.js",
                       "~/Scripts/bootstrap.bundle.min.js.map"
                      ));

            bundles.Add(new StyleBundle("~/Content/admin/css").Include(
                                 "~/css/dataTables.bootstrap5.min.css",

                                 "~/css/style.css"
                                 , "~/css/bootstrap.min.css"
                                 ,"~/css/bootstrap.min.css"
                                 
                                 )) ;

        }
    }
}
