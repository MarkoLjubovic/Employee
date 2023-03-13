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
        public static string AddString(string text)
        {
            string input;

            do
            {
                Console.WriteLine($"{text}:");
                input = Console.ReadLine();

                if (!Validations.StringValidation(input))
                {
                    Console.WriteLine("Can't be empty.");
                }
            }
            while (!Validations.StringValidation(input));


            return input;
        }

        public static int AddInt(string text)
        {
            string check;
            int input=0;

            do
            {
                Console.WriteLine($"{text}:");
                check = Console.ReadLine();

                if (!Validations.IntValidation(check, input))
                {
                    Console.WriteLine("Can't be empty or letter.");
                }

            } while (!Validations.IntValidation(check, input));

            input = Convert.ToInt32(check);
            return input;
        }

        public static bool AddBool(string text)
        {
            string check;
            bool input=false;

            do
            {
                Console.WriteLine($"{text}:");
                check = Console.ReadLine();

                if (!Validations.BoolValidation(check, input))
                {
                    Console.WriteLine("Needs to be true or false.");
                }

            } while (!Validations.BoolValidation(check, input));

            input=Convert.ToBoolean(check);
            return input;
        }

        public static void AddText()
        {
            Console.WriteLine("Available roles: CEO, PM, DEV, DSNR, ST.");
        }


        public static void Help()
        {
            Console.WriteLine("Available commands: 1. Add, 2. Remove, 3. Display, 4. List, 5. RoleList");
            Console.WriteLine("Pick one:");
        }

        public static string AddRole()
        {
            string role;

            do
            {
                Helper.AddText();
                role = Helper.AddString("Pick role you want to input");

            } while (Validations.RoleValidation(role) == false);

            return role;
        }

        private static int id = 1;
        public static int GenerateId()
        {
            return id++;
        }

        public static Guid GenerateGuid()
        {
            return Guid.NewGuid();
        }
    }
}
