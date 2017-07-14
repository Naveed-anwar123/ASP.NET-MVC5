using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspFirstApp.Repository
{
    public class Alluser : AlluserInterface
    {
        public IQueryable viewuser()
        {

            var obj = new DB3();
            var result = from signup in obj.signup select signup;
            return result;
        }
    }
}