using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CEO:Employee
    {
        public int CeoYears { get; set; }

        public override string FullInfo()
        {
            return $"Id:{Id}, Role:{Role}, FirstName:{FirstName}, LastName: {LastName}, Age:{Age}, CeoYears:{CeoYears}";
        }
    }
}
