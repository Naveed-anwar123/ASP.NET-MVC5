using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspFirstApp.Repository
{
    public class Records : RecordsInterface
    {
        public IQueryable viewrecords(string email)
        {
            var db = new DB3();
            var req = db.Requests.Where(x => x.email.Equals(email));
            return req;
        }
    }
}