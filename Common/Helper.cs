using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Helper
    {
        public static string AddString()
        {
            string unos=Console.ReadLine();
            return unos;
        }

        public static int AddInt()
        {
            int unos=Convert.ToInt32(Console.ReadLine());
            return unos;
        }

        public static void AddText()
        {
            Console.WriteLine("Option Add is picked.");
            Console.WriteLine("Available roles: CEO, PM, DEV, DSNR, ST. Pick role you want to input:");
        }

        public static bool AddBool()
        {
            bool unos=Convert.ToBoolean(Console.ReadLine());
            return unos;
        }

        public static void Help()
        {
            Console.WriteLine("Available commands: 1. Add, 2. Remove, 3. Display, 4. List, 5. RoleList");
            Console.WriteLine("Pick one:");
        }
    }
}
