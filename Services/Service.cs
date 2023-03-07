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
        protected readonly DSNRService _dsnrService;
        protected readonly PMService _pmService;
        protected readonly STService _sTService;
        public Service(IBaseService baseService, CEOService cEOService, DEVService devService, DSNRService dSNRService, PMService pMService, STService sTService)
        {
            _baseService = baseService;
            _ceoService = cEOService;
            _devService = devService;
            _dsnrService = dSNRService;
            _pmService = pMService;
            _sTService = sTService;
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
                    _ceoService.AddCEO();
                    Help(role);
                    break;

                case "dsnr":
                    _dsnrService.AddDSNR();
                    Help(role);
                    break;

                case "dev":
                    _devService.AddDeveloper();
                    Help(role);
                    break;

                case "pm":
                    _pmService.AddProjectManager();
                    Help(role);
                    break;

                case "st":
                    _sTService.AddSoftwareTester();
                    Help(role);
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
