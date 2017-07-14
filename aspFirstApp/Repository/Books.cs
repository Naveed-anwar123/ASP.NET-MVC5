using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspFirstApp.Repository
{
    public class Books : BookInterface
    {
        public void request(string email, int id)
        {
            var obj = new DB3();
            Requests r = new Requests();
            r.email = email;
            r.book_id = id;
            r.status = "Pending";
            obj.Requests.Add(r);
            obj.SaveChanges();
        }

    }
}