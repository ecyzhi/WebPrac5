using System;
using System.Web.Security;

namespace WebPrac5
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //MembershipCreateStatus status;
            //String[] adminRole = new string[] { "Admin" };
            //String[] userName = new string[] { "admin" };
            //SqlRoleProvider sqlRoleProvider = new SqlRoleProvider();
            //SqlMembershipProvider sqlMembershipProvider = new SqlMembershipProvider();
            //Guid guid = Guid.NewGuid();


            if (Roles.RoleExists("Admin") == false)
            {
                Membership.CreateUser("admin", "admin");
                Roles.CreateRole("Admin");
                Roles.AddUserToRole("admin", "Admin");
            }

            //if (sqlRoleProvider.RoleExists("Admin") == false)
            //{
            //    sqlRoleProvider.CreateRole(adminRole[0]);
            //    sqlMembershipProvider.CreateUser("admin", "admin", "admin@gmail.com", "", "", true, guid, out status);
            //    sqlRoleProvider.AddUsersToRoles(userName, adminRole);

            //}


        }
    }
}