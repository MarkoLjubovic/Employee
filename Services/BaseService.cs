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

        public  T Model { get; set; }
        public string role;

        public BaseService(T model, string role)
        {
            Model = model;
            this.role = role;
        }

        public virtual IEmployee AddEmployee()
        {
            Console.WriteLine("Id:");
            Model.Id = Common.Validations.IntValidation();
            Model.Role = role;
            Console.WriteLine("FirstName:");
            Model.FirstName = Common.Validations.StringValidation();
            Console.WriteLine("LastName:");
            Model.LastName = Common.Validations.StringValidation();
            Console.WriteLine("Age:");
            Model.Age = Common.Validations.IntValidation();

            return Model;
        }

        public void RoleList(string role)
        {
            Console.WriteLine("Type role:");
            role = Common.Helper.AddString().ToLower();

            if (EmployeeStorage.Storage.RoleExist(role))
            {
                foreach(var employee in EmployeeStorage.Storage.FindRole(role))
                {
                    Console.WriteLine(employee.FullInfo());
                }
            }
            else
            {
                Console.WriteLine("User with that role doesn't exist.");
            }
        }

        public void EmployeeList()
        {
            EmployeeStorage.Storage.DisplayWithoutCEO();
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
                Console.WriteLine(employee.FullInfo());
            }
        }
    }
}
