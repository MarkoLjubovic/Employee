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
        public IBaseService GetService(string search)
        {
            switch (search)
            {
                case "ceo":
                    _cEOService = new CEOService(new CEO());
                    return _cEOService;
                case "dev":
                    _dEVService = new DEVService(new Developer());
                    return _dEVService;
                case "dsnr":
                    _dsNRService = new DSNRService(new Designer());
                    return _dsNRService;
                case "pm":
                    _pmService = new PMService(new ProjectManager());
                    return _pmService;
                case "st":
                    _stService = new STService(new SoftwareTester());
                    return _stService;
            }
            return _baseService;
        }

        public void Help(string role)
        {
            Common.Helper.Help();
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
            IBaseService service = null;

            switch (search)
            {
                case "ceo":
                    service = GetService(search);
                    break;

                case "dsnr":
                    service = GetService(search);
                    break;

                case "dev":
                    service = GetService(search);
                    break;

                case "pm":
                    service = GetService(search);
                    break;

                case "st":
                    service = GetService(search);
                    break;
            }

            service.AddEmployee();
            Help(role);
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
