using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Domian
{
    public class Account
    {
        public int UserId { get; set; }
        public string Name {get; set;}
        public string Type { get; set; }
        public bool Active { get; set; }
    }
}