using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebPrac5
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Roles.RoleExists("Admin") == false)
            {
                Membership.CreateUser("admin", "admin");
                Roles.CreateRole("Admin");
                Roles.AddUserToRole("admin", "Admin");
            }
        }
    }
}