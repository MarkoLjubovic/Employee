using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISoftwareTester
    {
        string Project { get; set; }
        bool UsesAutomatedTests { get; set; }
    }
}
