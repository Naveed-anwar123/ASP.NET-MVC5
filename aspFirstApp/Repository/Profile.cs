using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspFirstApp.Repository
{
    public class Profile : ProfileInterface
    {
        public IQueryable view()
        {
            var obj = new DB3();
            var result = from signup in obj.signup select signup;
            return result;
        }
    }
}