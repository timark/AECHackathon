using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AECHackathon.Models;
using AECHackathon.Common;
using System.Text;

namespace AECHackathon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string autoDesk_creds = getAutoDeskAuthoToken.getAuthoToken();

            autoDesk_creds = autoDesk_creds.Replace("\r\n", "");

            ViewBag.autoDesk = "var auth_script='" + autoDesk_creds + "';";


            ViewBag.Title = "Model";
            int[] navList = { 0, 1, 2, 3, 4,5,7,9,10 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 4);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            StringBuilder objProp = new StringBuilder();
            objProp.Append("<li class='mega-dropdown' >");
            objProp.Append("<a href='#' class='mega-dropdown-toggle'><i class='fa fa-2x info fa-th-large'></i></a>");
            objProp.Append("<div class='dropdown-menu mega-dropdown-menu'>");
            objProp.Append("<div class='clearfix'>");
            objProp.Append("   <div class='col-sm-12 col-md-3'>");
            objProp.Append("     <!--Mega menu widget-->");
            objProp.Append("     <div class='text-center bg-purple pad-all'>");
            objProp.Append("       <h3 class='text-thin mar-no'>Product Selector</h3>");
            objProp.Append("       <div class='pad-ver box-inline'> <span class='icon-wrap icon-wrap-lg icon-circle bg-trans-light'> <i class='fa fa-cubes fa-4x'></i> </span> </div>");
            objProp.Append("       <p class='pad-btm'> Select Objects in the Model </p>");
            objProp.Append("     </div>");
            objProp.Append("   </div>");
            objProp.Append("   <div class='col-sm-4 col-md-3'>");
            objProp.Append("     <div class='panel'>");
            objProp.Append("        <!--Panel heading-->");
            objProp.Append("        <div class='panel-heading'>");
            objProp.Append("          <h3 class='panel-title'>Selected Object Properties</h3>");
            objProp.Append("        </div>");
            objProp.Append("        <!--Default panel contents-->");
            objProp.Append("        <div class='panel-body'>");
            objProp.Append("          <table class='table table-striped table-bordered'>");
            objProp.Append("            <thead>");
            objProp.Append("              <tr>");
            objProp.Append("                <th>Name</th>");
            objProp.Append("                <th>Value</th>");
            objProp.Append("              </tr>");
            objProp.Append("           </thead>");
            objProp.Append("            <tbody>");
            objProp.Append("              <tr>");
            objProp.Append("                <td>Selected Id</td>");
            objProp.Append("                <td id='model-selected-id'></td>");
            objProp.Append("              </tr>");
            objProp.Append("              <tr>");
            objProp.Append("                <td>Name</td>");
            objProp.Append("                <td id='model-selected-name'></td>");
            objProp.Append("              </tr>");
            objProp.Append("              <tr>");
            objProp.Append("                <td>ifcObjectType</td>");
            objProp.Append("                <td id='model-selected-ifcObjectType'></td>");
            objProp.Append("              </tr>");
            objProp.Append("            </tbody>");
            objProp.Append("          </table>");
            objProp.Append("        </div>");
            objProp.Append("      </div>");
            objProp.Append("    </div>");
            objProp.Append("    <div class='col-sm-8 col-md-6'>");
            objProp.Append("      <div class='panel'>");
            objProp.Append("        <!--Panel heading-->");
            objProp.Append("        <div class='panel-heading'>");
            objProp.Append("          <h3 class='panel-title'>Product Library</h3>");
            objProp.Append("        </div>");
            objProp.Append("        <!--Default panel contents-->");
            objProp.Append("        <div class='panel-body' id='supplierProductsTablePanel'>");
            /*
            objProp.Append("                           <table class='table table-striped table-bordered'");
            objProp.Append("                                data-search='true'");
            objProp.Append("                                data-show-refresh='true'");
            objProp.Append("                                data-show-toggle='true'");
            objProp.Append("                                data-show-columns='true'");
            objProp.Append("                                data-sort-name='id'");
            objProp.Append("                                data-page-list='[15, 20, 50]'");
            objProp.Append("                                data-page-size='15'");
            objProp.Append("                                data-pagination='true' data-show-pagination-switch='true'");
            objProp.Append("                                id='supplierProductTable'>");
            objProp.Append("                                <thead>");
            objProp.Append("                                    <tr>");
            objProp.Append("                                        <th data-field='SupplierName' data-sortable='true'>Manufacturer</th>");
            objProp.Append("                                        <th data-field='NoOfProducts' data-sortable='true'>Products</th>");
            objProp.Append("                                        <th data-hide='all' data-field='actionButtons' data-sortable='false'>Actions</th>");
            objProp.Append("                                    </tr>");
            objProp.Append("                                </thead>");
            objProp.Append("                                <tbody id='tableResults'></tbody>");
            objProp.Append("                            </table>");
             */
            objProp.Append("        </div>");
            objProp.Append("      </div>");
            objProp.Append("    </div>");
            objProp.Append("  </div>");
            objProp.Append("</div></li>");

            ViewBag.MegaMenu = objProp.ToString();



            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.Title = "Dashboard";
            int[] navList = { 0, 1 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 0);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Title = "Projects";
            int[] navList = { 0, 1 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 1);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }

        public ActionResult Project()
        {
            ViewBag.Title = "Project";
            int[] navList = { 0, 1, 2, 3, 4, 5, 7, 9, 10 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 2);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }

        public ActionResult Models()
        {
            ViewBag.Title = "Models";
            int[] navList = { 0, 1, 2, 3, 5, 7, 9, 10 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 3);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }

        public ActionResult Systems()
        {
            ViewBag.Title = "Systems";

            int[] navList = { 0, 1, 2, 3, 4, 5,10 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 5);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }

        public ActionResult System()
        {
            ViewBag.Title = "Systems";

            int[] navList = { 0, 1, 2, 3, 4, 5, 6,10 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 6);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }

        public ActionResult Schedules()
        {
            ViewBag.Title = "Schedules";

            int[] navList = { 0, 1, 2, 3, 4, 5, 10 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 10);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }

        public ActionResult Schedule()
        {
            ViewBag.Title = "Schedule";

            int[] navList = { 0, 1, 2, 3, 4, 5, 6, 10, 11 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 11);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }


        public ActionResult Suppliers()
        {
            ViewBag.Title = "Suppliers";

            int[] navList = { 0, 1, 2, 3, 4,5,6 ,7,10 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 7);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }

        public ActionResult Supplier()
        {
            ViewBag.Title = "Supplier";

            int[] navList = { 0, 1, 2, 3,  5, 6, 7, 8, 10 };

            NavBuilder nb = new NavBuilder();
            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();

            iMenuItems = nb.generateItems(navList, 8);

            NavBuilder navMenu = new NavBuilder();

            ViewBag.NavMenu = navMenu.generateMenu(iMenuItems);

            return View();
        }

        public ActionResult ProductData()
        {
            ViewBag.Title = "Product DataSheet";

            return View();
        }
    }
}
