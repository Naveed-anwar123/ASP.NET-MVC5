using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace aspFirstApp.Repository
{
    public interface HomeInterface
    {
        //public
        IQueryable addbooks();
        void saveBooks(string cname, string isbn, string catName);
        void updateBooks(Book b,int id);
    }
}
