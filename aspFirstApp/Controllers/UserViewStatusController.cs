using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class UserViewStatusController : Controller
    {
        //
        // GET: /UserViewStatus/
        public ActionResult viewStatus()
        {
            var db = new DB3();
            var request = db.Requests.Include("Book");
            // var all = from books in get.Book select books;
            //   ViewBag.display = books;
            return View(request);
        }
	}
}