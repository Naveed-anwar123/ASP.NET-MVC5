using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspFirstApp.Repository
{
    public class Category2 : CategoryInterface
    {

        public IQueryable view()
        {
            var obj = new DB3();
            var result = from cat in obj.Category select cat;
            return result;
        }

        public void savaCategories(Category c)
        {
            var obj = new DB3();
            obj.Category.Add(c);
            obj.SaveChanges();
        }
        public Category updateCategory(Category c , int id)
        {

            
            var db = new DB3();
            var result = db.Category.Single(i => i.Id == id);
            return result;
        }
        public void updatedCategory(Category c, int id)
        {


            
            var db = new DB3();
            var result = db.Category.Single(i => i.Id == id);
            result.name = c.name;
            result.Id = id;
            db.SaveChanges();
            
        }
    }
}