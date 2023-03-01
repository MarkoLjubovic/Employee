using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDeveloper:ICommon
    {
        string Project { get; set; }
        bool isStudent { get; set; }
    }
}
