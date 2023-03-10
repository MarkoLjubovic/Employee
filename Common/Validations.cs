using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class Validations
    {
        public static bool CommandValidation(string command)
        {

            if (Constants.AllCommnands.FirstOrDefault(c => c.Equals(command)) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RoleValidation(string role)
        {
            if (Constants.AllRoles.FirstOrDefault(c => c.Equals(role)) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string InputValidation()
        {
            var input = Helper.AddString().ToLower();

            return input;
        }

        public static bool BoolValidation()
        {
            bool input;
            while (!bool.TryParse(Helper.AddString(), out input))
            {
                Console.WriteLine("Input needs to be bool.");
            }
            return input;
        }

        public static int IntValidation()
        {
            int input;

            while (!int.TryParse(Helper.AddString(), out input))
            {
                Console.WriteLine("Can only input number.");
            }

            return input;

        }

        public static string StringValidation()
        {
            string input;
            input = Helper.AddString();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Can't be empty.");
                input = Helper.AddString();
            }

            return input;
        }
    }
}
