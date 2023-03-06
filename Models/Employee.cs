using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee:IEmployee
    {
        public int Id { get; set; }
        public string Role { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //public string FullInfo()
        //{
        //    return $"Id:{Id}, Role:{Role}, FirstName:{FirstName}, LastName: {LastName}, Age:{Age}";  
        //}

        public virtual string FullInfo()
        {
            return null;
        }
    }
}
