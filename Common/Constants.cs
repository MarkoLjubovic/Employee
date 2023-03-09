using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Constants
    {
        public class Command
        {
            public const string Add = "add";
            public const string Remove = "remove";
            public const string Display = "display";
            public const string List = "list";
            public const string RoleList = "role";
        }

        public class Role
        {
            public const string CEO = "ceo";
            public const string DSNR = "dsnr";
            public const string DEV = "dev";
            public const string PM = "pm";
            public const string ST = "st";
            public const string BASE = "base";
        }
    }
}
