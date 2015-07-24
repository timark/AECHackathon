using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AECHackathon.Models
{

    public class NavMenuGroupModel
    {
        public string menuGroupId { get; set; }
        public string Name { get; set; }
        public string icon { get; set; }
        public bool Status { get; set; } //true = open false = closed
        public List<NavMenuModel> NavMenus { get; set; }

    }

    public class NavMenuModel
    {
        public string menuId { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string handler { get; set; }
        public bool status { get; set; } //true = selected false = not selected

    }

}
