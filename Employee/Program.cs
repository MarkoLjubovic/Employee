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
            BaseService<Models.Employee> baseService = new BaseService<Models.Employee>(employee, employee.Role);
            Service service = new Service(baseService);
            service.Help("");
        }
    }
}
