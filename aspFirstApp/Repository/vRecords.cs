using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspFirstApp.Repository
{
    public class vRecords : vRecordsInterface
    {
        public IQueryable vrecords()
        {
            var db = new DB3();
            var req = from x in db.Requests select x;
            return req;
        }
        public void deleted(int id)
        {
            var db = new DB3();
            Requests r = db.Requests.Single(u => u.Id == id);
            db.Requests.Remove(r);
            db.SaveChanges();
        }
    }
}