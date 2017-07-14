using aspFirstApp.Models;
using aspFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class AddCategoryController : Controller
    {
        //
        // GET: /AddCategory/
        CategoryInterface data = null;
        public AddCategoryController(CategoryInterface data)
        {
            this.data = data;
        }

        public ActionResult categoryForm()
        {
            return View();
        }

        public ActionResult viewCategories()
        {
           

            ViewBag.a = data.view();
            return View();
        }

        [HttpPost]
        public ActionResult getCategory(Category c)
        {
            data.savaCategories(c);
            return RedirectToAction("AddBooks","AddBooks");
            
        }
        public void delete()
        {
            int id = Int32.Parse(Request["p"]);
            var db = new DB3();
            //var result = db.Book.Include("Category").FirstOrDefault(u => u.catId == id);
            //db.Book.Remove(result);
            var result1 = db.Category.FirstOrDefault(u => u.Id == id);
            db.Category.Remove(result1);
            
            //db.SaveChanges();

        }
        public ActionResult update(Category c)
        {
            int id = Int32.Parse(Request["p"]);
            ViewBag.a = data.updateCategory(c,id);
            return View();

        }
        public ActionResult updated(Category c)
        {
            int id = Int32.Parse(Request["p"]);
            data.updatedCategory(c, id);   
            return RedirectToAction("viewCategories");
            

        }
        
            
	}
}