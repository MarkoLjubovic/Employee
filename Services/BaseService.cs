using Interfaces;
using Models;
using Services.Interface;
using Storage.IStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BaseService<T> : IBaseService where T : IEmployee
    {
        private  T Model { get; set; }
        private string role;

        public BaseService(T model, string role)
        {
            Model = model;
            this.role = role;
        }

        public IEmployee AddEmployee()
        {
            Console.WriteLine("Role:");
            Model.Role = role;
            Console.WriteLine("FirstName:");
            Model.FirstName = Console.ReadLine();
            Console.WriteLine("LastName:");
            Model.LastName = Console.ReadLine();
            Console.WriteLine("Age:");
            Model.Age = Convert.ToInt32(Console.ReadLine());

            return Model;
        }

        public void RoleList()
        {
            Console.WriteLine("Type role:");
            string role=Console.ReadLine();

            foreach (var employee in EmployeeStorage.Storage.FindRole(role))
            {
                employee.FullInfo();
            }
        }

        public void EmployeeList()
        {
            foreach(var employee in EmployeeStorage.Storage.Employees())
            {
                if (employee.Role != "CEO")
                {
                    employee.FullInfo();
                }
            }
        }

        public bool RemoveEmployee()
        {
            Console.WriteLine("Input Employee Id:");
            var employeeId=Convert.ToInt32(Console.ReadLine());

            var employeeToRemove = EmployeeStorage.Storage.Employees().FirstOrDefault(x => x.Id == employeeId);

            if(employeeToRemove != null)
            {
                if (EmployeeStorage.Storage.RemoveEmployee(employeeToRemove))
                {
                    Console.WriteLine($"Employee with id {employeeToRemove.Id} is removed.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Employee with id { employeeToRemove.Id} is not removed.");
                    return false;
                }
            }

            else
            {
                Console.WriteLine($"Employee with id {employeeId} not found.");
                return false;
            }
        }

        public void EmployeeDisplay()
        {
            foreach (var employee in EmployeeStorage.Storage.Employees())
            {
                employee.FullInfo();
            }
        }
    }
}
