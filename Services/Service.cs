using EmployeeStorage;
using Interfaces;
using Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Service : IService
    {
        protected readonly IBaseService _baseService;
        public Service(IBaseService baseService)
        {
            _baseService = baseService;
        }

        CEOService _cEOService;
        DEVService _dEVService;
        DSNRService _dsNRService;
        PMService _pmService;
        STService _stService;

        public void Help(string role)
        {
            Common.Helper.HelpText();
            var search = Common.Helper.AddString().ToLower();

            switch (search)
            {
                case "add":
                    Add(role);
                    break;

                case "remove":
                    Remove();
                    Help(role);
                    break;

                case "display":
                    Display();
                    Help(role);
                    break;

                case "list":
                    List();
                    Help(role);
                    break;

                case "role":
                    RoleList(role);
                    Help(role);
                    break;
            }
        }
        public void Add(string role)
        {
            Common.Helper.AddText();
            var search = Common.Helper.AddString().ToLower();

            switch (search)
            {
                case "ceo":
                    _cEOService = new CEOService(new CEO());
                    _cEOService.AddEmployee();
                    Help(role);
                    break;

                case "dsnr":
                    _dsNRService = new DSNRService(new Designer());
                    _dsNRService.AddEmployee();
                    Help(role);
                    break;

                case "dev":
                    _dEVService = new DEVService(new Developer());
                    _dEVService.AddEmployee();
                    Help(role);
                    break;

                case "pm":
                    _pmService=new PMService(new ProjectManager());
                    _pmService.AddEmployee();
                    Help(role);
                    break;

                case "st":
                    _stService=new STService(new SoftwareTester());
                    _stService.AddEmployee();
                    Help(role);
                    break;
            }

        }

        public void RoleList(string role)
        {
            Console.WriteLine("Type role:");
            role = Common.Helper.AddString().ToUpper();
            _baseService.RoleList(role);
        }

        public void Remove()
        {
            _baseService.RemoveEmployee();
        }

        public void Display()
        {
            _baseService.EmployeeDisplay();
        }

        public void List()
        {
            _baseService.EmployeeList();
        }
    }

}
