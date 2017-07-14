using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspFirstApp.Repository
{
    public class Requestclass : RequestInterface
    {
        public void accepted(int id)
        {
            var db = new DB3();
            db.Requests.First(x => x.Id.Equals(id)).status = "Accepted";
            db.Requests.First(x => x.Id.Equals(id)).issue_date = DateTime.Now;
            db.SaveChangesAsync();
            
        }
        public void rejected(int id)
        {
            var db = new DB3();
            db.Requests.First(x => x.Id.Equals(id)).status = "Rejected";
            db.SaveChanges();
        }
    }
}