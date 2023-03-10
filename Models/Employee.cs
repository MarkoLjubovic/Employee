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
        public Guid Guid { get; set; }
        public int Id { get; set; }
        public string Role { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public virtual string FullInfo()
        {
            return $"Guid:{Guid}, Role:{Role}, FirstName:{FirstName}, LastName: {LastName}, Age:{Age}";
        }
    }
}
