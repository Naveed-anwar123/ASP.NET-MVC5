using aspFirstApp.Models;
using aspFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class ViewRecordsController : Controller
    {
        //
        // GET: /ViewRecords/
        vRecordsInterface data = null;
        public ViewRecordsController(vRecordsInterface data)
        {
            this.data = data;
        }
        public ActionResult viewIssueRecord()
        {
            return View(data.vrecords());   
        }
        public ActionResult delete()
        {
            int id = Int32.Parse(Request["p"]);
            data.deleted(id);
            return RedirectToAction("viewIssueRecord");
        }
	}
}