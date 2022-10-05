using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zippersale.Models
{
    public class User
    {
        public Guid userID {get;set;}
        public Guid loginID {get;set;}
        public string name {get;set;}
        public string lastname {get;set;}
        public string phone2 {get;set;}
        public string phone1 {get;set;}
        public string email {get;set;}
        public DateTime birthday {get;set;}
        public int age {get;set;}
        public int zipcode {get;set;}
        public bool sex {get;set;} 
    }
}