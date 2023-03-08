using Common;
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
        private readonly Service _service;
        public Execute(Service service)
        {
            _service = service;
        }
        public static void ExecuteProgram(string role, Service service)
        {
            Helper.Help();
            var search = Helper.AddString().ToLower();

            switch (search)
            {
                case "add":
                    
                    service.Add(role, service);
                    break;

                case "remove":
                    service.Remove();
                    break;

                case "display":
                    service.Display();
                    break;

                case "list":
                    service.List();
                    break;

                case "role":
                    service.RoleList(role);
                    break;
            }
            ExecuteProgram(role,service);
        }

        public static void Add(string role, Service service)
        {
            Common.Helper.AddText();
            var search = Common.Helper.AddString().ToLower();
            IBaseService iService = null;

            switch (search)
            {
                case "ceo":
                    iService = service.GetService(search);
                    break;

                case "dsnr":
                    iService = service.GetService(search);
                    break;

                case "dev":
                    iService = service.GetService(search);
                    break;

                case "pm":
                    iService = service.GetService(search);
                    break;

                case "st":
                    iService = service.GetService(search);
                    break;
            }

            iService.AddEmployee();
            ExecuteProgram(role,service);
        }
    }
}
