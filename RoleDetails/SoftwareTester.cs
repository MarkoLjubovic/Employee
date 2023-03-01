using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class SoftwareTester: Common, ISoftwareTester
    {
        public string Project { get; set; }
        public bool UsesAutomatedTests { get; set; }
    }
}
