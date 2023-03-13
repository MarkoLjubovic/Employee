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
            return Console.ReadLine().ToLower();
        }

        public static bool BoolValidation(string check, bool input)
        {
            return bool.TryParse(check, out input);
        }

        public static bool IntValidation(string check, int input)
        {
            return int.TryParse(check, out input);
        }

        public static bool StringValidation(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            return true;
        }
    }
}
