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

        public void Help(string role, Service service)
        {
            Execute.Execute.ExecuteProgram(role, service);
        }
        public void Add(string role, Service service)
        {
            Execute.Execute.Add(role, service);
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
