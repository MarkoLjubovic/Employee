﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class SoftwareTester: ISoftwareTester
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Project { get; set; }
        public bool UsesAutomatedTests { get; set; }
    }
}
