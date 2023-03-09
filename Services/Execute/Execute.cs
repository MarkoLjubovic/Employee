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
            var search = Helper.AddString().ToLower();

            switch (search)
            {
                case Constants.Command.Add:
                    AddCommand(role);
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

        public static void AddCommand(string role)
        {
            Helper.AddText();
            var search = Helper.AddString().ToLower();
            IBaseService service = null;

            switch (search)
            {
                case Constants.Role.CEO:
                    service = ServiceFactory.ServiceFactory.GetService("ceo");
                    break;

                case Constants.Role.DSNR:
                    service = ServiceFactory.ServiceFactory.GetService("dsnr");
                    break;

                case Constants.Role.DEV:
                    service = ServiceFactory.ServiceFactory.GetService("dev");
                    break;

                case Constants.Role.PM:
                    service = ServiceFactory.ServiceFactory.GetService("pm");
                    break;

                case Constants.Role.ST:
                    service = ServiceFactory.ServiceFactory.GetService("st");
                    break;
            }

            service.AddEmployee();
            ExecuteProgram(role);
        }
    }
}
