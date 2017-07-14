using aspFirstApp.Models;
using aspFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class UserProfileController : Controller
    {
        //
        // GET: /UserProfile/
        ProfileInterface data = null;
        public UserProfileController(ProfileInterface data)
        {
            this.data = data;
        }
        public ActionResult viewProfile()
        {
            ViewBag.a = data.view();

            return View();
            
        }
	}
}