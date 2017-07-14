using aspFirstApp.Models;
using aspFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class ViewUserRequestController : Controller
    {
        //
        // GET: /ViewUserRequest/
        RequestInterface data = null;
        public ViewUserRequestController(RequestInterface data)
        {
            this.data = data;
        }
        public ActionResult viewRequest()
        {
            var db = new DB3();
            var request = db.Requests.Include("Book");
            
            return View(request);
            
        
        }

        public ActionResult accept()
        {

            var db = new DB3();
            int id = Int32.Parse(Request["p"]);
            data.accepted(id);
            
            return RedirectToAction("viewRequest");
        }

        public ActionResult reject()
        {
            int id = Int32.Parse(Request["p"]);
            var db = new DB3();
            data.rejected(id);
            return RedirectToAction("viewRequest");
        }
	}
}