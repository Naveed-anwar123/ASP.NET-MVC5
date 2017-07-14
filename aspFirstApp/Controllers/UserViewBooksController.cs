using aspFirstApp.Models;
using aspFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class UserViewBooksController : Controller
    {
        //
        // GET: /UserViewBooks/
        BookInterface data = null;
        public UserViewBooksController(BookInterface data)
        {
            this.data = data;
        }
        public ActionResult viewBooks()
        {
            var get = new DB3();
            var books = get.Book.Include("Category");
            return View(books);
        }
        public ActionResult bookRequest()
        {
            int id = Int32.Parse(Request["p"]);
            data.request(HttpContext.Session["name"].ToString(), id);
            return RedirectToAction("viewStatus", "UserViewStatus");
        }

	}
}