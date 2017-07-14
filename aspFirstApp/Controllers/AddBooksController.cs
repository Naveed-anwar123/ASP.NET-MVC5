using aspFirstApp.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspFirstApp.Repository;
namespace aspFirstApp.Controllers
{
    public class AddBooksController : Controller
    {
        //
        // GET: /AddBooks/
        HomeInterface data;
        public AddBooksController(HomeInterface data)
        {
            this.data = data;
        }

        public ActionResult AddBooks()
        {

            IQueryable result = data.addbooks();
            ViewBag.a = result;
            return View();
            
        }
        [HttpPost]
        public ActionResult getBooks(string cname, string isbn, string catName)
        {
            data.saveBooks(cname, isbn, catName);
            return RedirectToAction("viewBooks", "viewBooks");
        }

        public ActionResult updateBooks(Book b)
        {
            int id = Int32.Parse(Request["p"]);
            data.updateBooks(b, id);
            return RedirectToAction("viewBooks", "viewBooks");
        }

	}
}