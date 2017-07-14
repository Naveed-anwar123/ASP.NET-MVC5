using aspFirstApp.Models;
using aspFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class ViewAllUsersController : Controller
    {
        //
        // GET: /ViewAllUsers/
         AlluserInterface data = null;
        public ViewAllUsersController (AlluserInterface data)
         {
             this.data = data;

        }
        public ActionResult viewUser()
        {
            
            ViewBag.a = data.viewuser();
            return View();
        }

        public ActionResult viewDetails()
        {
            var p = Int32.Parse(Request["p"]);
            var obj = new DB3();
            var result = from signup in obj.signup where signup.Id==p select signup;
            ViewBag.a = result;

            return View();
        }
	}
}