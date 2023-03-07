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
        protected readonly CEOService _ceoService;
        protected readonly DEVService _devService;
        public Service(IBaseService baseService, CEOService cEOService, DEVService devService)
        {
            _baseService = baseService;
            _ceoService = cEOService;
            _devService = devService;
        }

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
                    //Help(employees);
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
                    _ceoService.AddCEO();
                    Help(role);
                    break;

                case "dsnr":
                    //Add(employees);
                    //Help(employees);
                    break;

                case "dev":
                    _devService.AddDeveloper();
                    Help(role);
                    break;

                case "pm":
                    //Add(employees);
                    //Help(employees);
                    break;

                case "st":
                    //Add(employees);
                    //Help(employees);
                    break;
            }
        }

        public void RoleList(string role)
        {
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
