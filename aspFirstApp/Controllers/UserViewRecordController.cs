using aspFirstApp.Models;
using aspFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Controllers
{
    public class UserViewRecordController : Controller
    {
        //
        // GET: /UserViewRecord/
        RecordsInterface data = null;
        public UserViewRecordController(RecordsInterface data)
        {
            this.data = data;
        }
        public ActionResult viewRecord()
        {


            
            string email = Session["name"].ToString();

            
                //List<Requests> l = result.ToList();
                return View(data.viewrecords(email));
        }
	}
}