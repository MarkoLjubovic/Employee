using EmployeeStorage;
using Models;
using Services;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Models.Employee employee = new Models.Employee();
            CEO cEO = new CEO();
            Developer developer = new Developer();
            Designer designer = new Designer();
            ProjectManager projectManager = new ProjectManager();
            SoftwareTester softwareTester = new SoftwareTester();
            CEOService cEOService = new CEOService(cEO, "CEO");
            DEVService dEVService = new DEVService(developer,"DEV");
            DSNRService dSNRService = new DSNRService(designer, "DSNR");
            PMService pmService = new PMService(projectManager, "PM");
            STService stService = new STService(softwareTester,"ST");
            BaseService<Models.Employee> baseService = new BaseService<Models.Employee>(employee, employee.Role);
            Service service = new Service(baseService, cEOService, dEVService, dSNRService,pmService, stService);
            service.Help("");
        }
    }
}
