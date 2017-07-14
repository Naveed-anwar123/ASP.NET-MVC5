using aspFirstApp.Models;
using aspFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class SignupController : Controller
    {
        //
        // GET: /Home1/
        SignInterface data = null;
        public SignupController(SignInterface data)
        {
            this.data = data;
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signUpData(signup su)
        {
            data.signup(su);
            return RedirectToAction("Index", "Login");
            
        }
	}
}