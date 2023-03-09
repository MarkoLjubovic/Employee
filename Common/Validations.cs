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
                Console.WriteLine($"Option {command} is picked.");
                return true;
            }
            else
            {
                Console.WriteLine("That command doesn't exists, input again.");
                return false;
            }
        }

        public static bool RoleValidation(string role)
        {
            if (Constants.AllRoles.FirstOrDefault(c => c.Equals(role)) != null)
            {
                Console.WriteLine($"Option {role} is picked.");
                return true;
            }
            else
            {
                Console.WriteLine("That role doesn't exists, input again.");
                return false;
            }
        }

        public static string TextValidation()
        {
            var input = Helper.AddString().ToLower();

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

            do
            {
               input=Helper.AddString();
                Console.WriteLine("Can't be empty, input again.");

            } while (string.IsNullOrEmpty(input));

            return input;
        }
    }
}
