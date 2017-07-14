using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspFirstApp.Repository
{
    public class Signup : SignInterface
    {
        public void signup(signup s)
        {

            var db = new DB3();
            db.signup.Add(s);
            db.SaveChanges();
        }
    }
}