using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Designer: Common,IDesigner
    {
        public string Project { get; set; }
        public bool CanDraw { get; set; }
    }
}
