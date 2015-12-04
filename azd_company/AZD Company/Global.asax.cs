using AZD_Company.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AZD_Company
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ApplicationDbContext db = new ApplicationDbContext();
            RoleStore<MyApplicationRole> rolestore = new RoleStore<MyApplicationRole>(db);
            RoleManager<MyApplicationRole> rolemanager = new RoleManager<MyApplicationRole>(rolestore);

            if (!rolemanager.RoleExists("Customer"))
            {
                MyApplicationRole newrole = new MyApplicationRole("Customer", "administrators can add, edit and delete data.");
                rolemanager.Create(newrole);
            }

            if (!rolemanager.RoleExists("Admin"))
            {
                MyApplicationRole newrole = new MyApplicationRole("Admin", "operators can only add or edit data.");
                rolemanager.Create(newrole);
            }

            if (!rolemanager.RoleExists("Producion"))
            {
                MyApplicationRole newrole = new MyApplicationRole("Producion", "operators can only add or edit data.");
                rolemanager.Create(newrole);
            }

            if (!rolemanager.RoleExists("Sales"))
            {
                MyApplicationRole newrole = new MyApplicationRole("Sales", "operators can only add or edit data.");
                rolemanager.Create(newrole);
            }

            if (!rolemanager.RoleExists("Finance"))
            {
                MyApplicationRole newrole = new MyApplicationRole("Finance", "operators can only add or edit data.");
                rolemanager.Create(newrole);
            }
            if (!rolemanager.RoleExists("Purchase"))
            {
                MyApplicationRole newrole = new MyApplicationRole("Purchase", "operators can only add or edit data.");
                rolemanager.Create(newrole);
            }

            if (!rolemanager.RoleExists("HumanResource"))
            {
                MyApplicationRole newrole = new MyApplicationRole("HumanResource", "operators can only add or edit data.");
                rolemanager.Create(newrole);
            }

            if (!db.Users.Any(u => u.UserName == "pasan19"))
            {
                var store = new UserStore<ApplicationUser>(db);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "pasan19" };
                manager.Create(user, "test123");
                manager.AddToRole(user.Id, "Admin");
            }
        }





            
    }
}
