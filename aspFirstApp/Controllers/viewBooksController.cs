using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class viewBooksController : Controller
    {
        //
        // GET: /viewBooks/
        public ActionResult viewBooks()
        {
            var get = new DB3();
            var books = get.Book.Include("Category");
            return View(books);
        }

     
        public JsonResult get()
        {
           string val = Request["val"];
           var db = new DB3();
           //var obj = new Book { cname = val };
           //var obj = db.Book.All();
           var a = from b in db.Book  select b;
            foreach(var bbb in a)
            {
                if(bbb.cname.Contains(val))
                {
                        return Json(bbb.cname, JsonRequestBehavior.AllowGet);
                }
            }

            return Json("Sorry", JsonRequestBehavior.AllowGet);
           //var res = a.Single();
          // var results = db.Book.Where(e=>e.cname.Equals(val));
          // var obj = from d in db.Book where d.cname == val select d;
            
           
           
               
           
            

        }
//        public ActionResult delete()
        
        public string delete()
        {

            int id = Int32.Parse(Request["p"]);
            int id1 = Int32.Parse(Request["p1"]);
            var db = new DB3();


            using (var conn = new DB3())
            {
                // return one instance each entity by primary key
                var product = conn.Book.FirstOrDefault(p => p.Id ==id);
                

                // call Remove method from navigation property for any instance
                // supplier.Product.Remove(product);
                // also works
                //product.Supplier.Remove(supplier);
                conn.Book.Remove(product);
                // call SaveChanges from context
                conn.SaveChangesAsync();
            }






            //var all = from b in db.Book where b.Id == id select b;
            //Book r = db.Book.Single(u => u.Id == id);
            //r.catId = null;
            //foreach(Book bb in all)
            //{ db.Book.Remove(bb);
            //Book r = db.Book.Single(u => u.Id == id);

            //AdventureWorksEntities context = new AdventureWorksEntities();
                
            //db.Book.Remove(r);
               
                
            //}

            return id + " :" + id1;
            //return RedirectToAction("viewBooks");

        }
        public ActionResult update()
        {

            int id = Int32.Parse(Request["p"]);
            var db = new DB3();
            
            var ubook = from b in db.Book where b.Id == id select b;
            var result = db.Book.Include("Category");
            ViewBag.a = result;
            return View(ubook);
        }
       
	}
}