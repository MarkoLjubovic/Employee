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
            Console.WriteLine("Id:");
            Model.Id= Common.Helper.AddInt();
            Model.Role = role;
            Console.WriteLine("FirstName:");
            Model.FirstName = Common.Helper.AddString();
            Console.WriteLine("LastName:");
            Model.LastName = Common.Helper.AddString();
            Console.WriteLine("Age:");
            Model.Age = Common.Helper.AddInt();

            return EmployeeStorage.Storage.AddEmployee(Model);
        }

        public void RoleList(string role)
        {
            Console.WriteLine("Type role:");
            role=Common.Helper.AddString().ToUpper();

            foreach (var employee in EmployeeStorage.Storage.FindRole(role))
            {
                Common.Helper.DisplayEmployees(employee);
            }
        }

        public void EmployeeList()
        {
            foreach (var employee in EmployeeStorage.Storage.DisplayWithoutCEO())
            {
                Common.Helper.DisplayEmployees(employee);
            }
        }

        public bool RemoveEmployee()
        {
            Console.WriteLine("Input Employee Id:");
            var employeeId=Convert.ToInt32(Console.ReadLine());

            var employeeToRemove = EmployeeStorage.Storage.Display().FirstOrDefault(x => x.Id == employeeId);

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
            foreach (var employee in EmployeeStorage.Storage.Display())
            {
                Common.Helper.DisplayEmployees(employee);
            }
        }
    }
}
