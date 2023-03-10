using Interfaces;
using Storage.IStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStorage
{
    public class Storage
    {
        public static List<IEmployee> employeesList=new List<IEmployee>();

        public static IEmployee AddEmployee<T>(T employee) where T : IEmployee
        {
            employeesList.Add(employee);
            return employee;
        }

        public static bool RemoveEmployee(IEmployee employee)
        {
            return employeesList.Remove(employee);
        }

        public static List<IEmployee> Display()
        {
            return employeesList;
        }

        public static List<IEmployee> DisplayWithoutCEO()
        {
            foreach (var employee in employeesList)
            {
                if (employee.Role != "CEO")
                {
                    employee.FullInfo();
                }
            }

            return employeesList;
        }

        public static List<IEmployee> FindRole(string role)
        {
            return employeesList.Where(x=>x.Role==role).ToList();
        }

        public static bool RoleExist(string role)
        {
            return employeesList.Exists(x=>x.Role==role);
        }
    }
}
