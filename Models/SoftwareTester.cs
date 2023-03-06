using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SoftwareTester : Employee
    {
        public string Project { get; set; }
        public bool UsesAutomatedTests { get; set; }

        public override string FullInfo()
        {
            return $"Id:{Id}, Role:{Role}, FirstName:{FirstName}, LastName: {LastName}, Age:{Age}, Project:{Project}, UsesAutomatedTests:{UsesAutomatedTests}";
        }
    }
}
