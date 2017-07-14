using aspFirstApp.Models;
using aspFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Home/
       
        public ActionResult Index()
        {
            return View();
        }
       [HttpPost]
        public ActionResult signInData(signup s)
        {
           string o=null, k=null;
           string email = Request["email"];
           string pass = Request["pass"];
           var db = new DB3();
           
           var login = from signup in db.signup select signup;

           try
           {
               var user = login.Single(u => u.email == s.email && u.pass == s.pass);
               if (user != null)
               {
                    o="sign in";
                    Session["name"]=email;
               }
           }
           catch(Exception e)
           {
                   
                   if(email == "admin@admin" && pass=="admin")
                   {
                       Session["id"] = "Admin";
                       return RedirectToAction("Home", "Admin");
                   }
           }
           return RedirectToAction("Index", "User");

        }



        public ActionResult logout()
       {
           Session.Clear();

           return RedirectToAction("Index","Login");
       }


	}
}