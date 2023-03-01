using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class CEO : Common,ICEO
    {
        public int CeoYears { get; set; }
    }
}
