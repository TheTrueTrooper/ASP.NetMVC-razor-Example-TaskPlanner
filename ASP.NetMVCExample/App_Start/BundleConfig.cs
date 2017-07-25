﻿using System.Web;
using System.Web.Optimization;

namespace ASP.NetMVCExample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

//#if DEBUG
////BundleTable.EnableOptimizations = false;
////            bundles.Add(new ScriptBundle("~/bundles/mainJs")
////      .Include("~/Scripts/mainSite.js")
////      .Include("~/Scripts/helperStuff.js"));
////after a push up date all
//#endif


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // my scriptBundles
            // libs
            bundles.Add(new ScriptBundle("~/bundles/MomentJS").Include("~/Scripts/Moment.js"));
            //per page 
            //bundles.Add(new ScriptBundle("~/bundles/About").IncludeDirectory("~/Scripts/PageScripts/About/", "*.js"));
            bundles.Add(new ScriptBundle("~/bundles/About").Include("~/Scripts/PageScripts/About/*.js"));

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


            // my styleBundles
            //libs

            //per page
            bundles.Add(new StyleBundle("~/Content/Project").IncludeDirectory("~/Content/PageCss/Dashboard/", "*.css"));
        }
    }
}
