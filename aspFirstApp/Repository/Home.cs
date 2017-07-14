using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspFirstApp.Repository
{
    public class Home : HomeInterface
    {
        public IQueryable addbooks()
        {
            var obj = new DB3();
            var result = from Category in obj.Category select Category;
            return result;
        }

        public void saveBooks(string cname, string isbn, string catName)
        {
            var obj = new DB3();

            var cat = from bb in obj.Category where bb.name == catName select bb;
            Book b = new Book();
            b.cname = cname;
            b.isbn = isbn;
            b.catId = cat.First().Id;
            //  b.catId = Int32.Parse(catId);

            obj.Book.Add(b);
            obj.SaveChanges();
        }
        public void updateBooks(Book b,int id)
        {
            
            // int cat = Int32.Parse(Request["p1"]);

            var db = new DB3();
            var result = db.Book.Single(i => i.Id == id);
            result.cname = b.cname;
            result.isbn = b.isbn;
            result.catId = result.catId;

            db.SaveChanges();



        }
    }
}