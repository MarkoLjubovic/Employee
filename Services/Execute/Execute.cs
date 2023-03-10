using Common;
using Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Execute
{
    public class Execute
    {
        private static IBaseService _service = ServiceFactory.ServiceFactory.GetService(Constants.Role.BASE);

        public static void ExecuteProgram(string role)
        {
            Helper.Help();
            var search=Validations.TextValidation();
            Validations.CommandValidation(search);

            switch (search)
            {
                case Constants.Command.Add:
                    AddCommand();
                    break;

                case Constants.Command.Remove:
                    _service.RemoveEmployee();
                    break;

                case Constants.Command.Display:
                    _service.EmployeeDisplay();
                    break;

                case Constants.Command.List:
                    _service.EmployeeList();
                    break;

                case Constants.Command.RoleList:
                    _service.RoleList(role);
                    break;
            }

            ExecuteProgram(role);
        }

        public static void AddCommand()
        {
            string role;
            role=Helper.AddRole();

            IBaseService service =null;

            switch (role)
            {
                case Constants.Role.CEO:
                    if (EmployeeStorage.Storage.RoleExist(role))
                    {
                        Console.WriteLine("Ceo already exists.");
                        return;
                    }
                    service = ServiceFactory.ServiceFactory.GetService(role);
                    break;

                case Constants.Role.DSNR:
                    service = ServiceFactory.ServiceFactory.GetService(role);
                    break;

                case Constants.Role.DEV:
                    service = ServiceFactory.ServiceFactory.GetService(role);
                    break;

                case Constants.Role.PM:
                    service = ServiceFactory.ServiceFactory.GetService(role);
                    break;

                case Constants.Role.ST:
                    service = ServiceFactory.ServiceFactory.GetService(role);
                    break;
            }

            service.AddEmployee();
            ExecuteProgram(role);
        }
    }
}
