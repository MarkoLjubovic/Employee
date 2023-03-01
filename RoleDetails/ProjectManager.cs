using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class ProjectManager: Common, IProjectManager
    {
        public string Project { get; set; }
    }
}
