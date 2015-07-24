using AECHackathon.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using System.Linq;

namespace AECHackathon
{
    public class NavBuilder
    {
        public List<NavMenuModel> getNavList()
        {
            List<NavMenuModel> objList = new List<NavMenuModel>();

            //0
            objList.Add(new NavMenuModel { name = "Dashboard", menuId = "menu-dashboard", handler = "/home/dashboard", icon = "fa-dashboard", status = false });
            //1
            objList.Add(new NavMenuModel { name = "Projects", menuId = "menu-projects", handler = "/home/projects", icon = "fa-building", status = false });
            //2
            objList.Add(new NavMenuModel { name = "Project", menuId = "menu-project", handler = "/home/project", icon = "fa-building", status = false });
            //3
            objList.Add(new NavMenuModel { name = "Models", menuId = "menu-models", handler = "/home/models", icon = "fa-cubes", status = false });
            //4
            objList.Add(new NavMenuModel { name = "Model", menuId = "menu-models", handler = "/home/index", icon = "fa-cube", status = false });
            //5
            objList.Add(new NavMenuModel { name = "Systems", menuId = "menu-systems", handler = "/home/systems", icon = "fa-sitemap", status = false });
            //6
            objList.Add(new NavMenuModel { name = "System", menuId = "menu-system", handler = "/home/system", icon = "fa-sitemap", status = false });
            //7
            objList.Add(new NavMenuModel { name = "Suppliers", menuId = "menu-suppliers", handler = "/home/suppliers", icon = "fa-cubes", status = false });
            //8
            objList.Add(new NavMenuModel { name = "Supplier", menuId = "menu-supplier", handler = "/home/supplier", icon = "fa-cubes", status = false });
            //9
            objList.Add(new NavMenuModel { name = "Products", menuId = "menu-products", handler = "/home/products", icon = "fa-cube", status = false });
            //10
            objList.Add(new NavMenuModel { name = "Schedules", menuId = "menu-schedules", handler = "/home/schedules", icon = "fa-list", status = false });
            //11
            objList.Add(new NavMenuModel { name = "Schedule", menuId = "menu-schedule", handler = "/home/schedule", icon = "fa-list", status = false });
            


            return objList;
        }

        public string generateMenu(List<NavMenuModel> iMenuItems)
        {
            StringBuilder menu = new StringBuilder();

            for (var i = 0; i < iMenuItems.Count; i++)
            {
                Trace.Write(iMenuItems[i].handler);

                if (iMenuItems[i].status == true)
                {
                    menu.Append("<li id='" + iMenuItems[i].menuId + "' class='active-sub'>");
                }
                else
                {
                    menu.Append("<li id='" + iMenuItems[i].menuId + "'>");
                }
                menu.Append("<a href='" + iMenuItems[i].handler + "'>");
                menu.Append("<i class='fa  " + iMenuItems[i].icon + "'></i>");
                menu.Append("<span class='menu-title'><strong>" + iMenuItems[i].name + "</strong> </span>");
                menu.Append("</a></li>");
            }

            return menu.ToString();
        }

        public List<NavMenuModel> generateItems(int[] items, int active)
        {

            List<NavMenuModel> iItems = new List<NavMenuModel>();

            iItems = getNavList();

            List<NavMenuModel> iMenuItems = new List<NavMenuModel>();
            for (var i = 0; i < iItems.Count; i++)
            {
                if (items.Contains(i))
                {
                    if (i == active)
                    {
                        iItems[i].status = true;
                    }
                    iMenuItems.Add(iItems[i]);
                }

            }
            return iMenuItems;
        }
    }


}