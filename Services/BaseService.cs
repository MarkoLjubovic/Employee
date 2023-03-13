﻿using Common;
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
            Model.Guid = Helper.GenerateGuid();
            Model.Id = Helper.GenerateId();
            Model.Role = role;
            Model.FirstName = Helper.AddString("FirstName");
            Model.LastName = Helper.AddString("LastName");
            Model.Age = Helper.AddInt("Age");

            return Model;
        }

        public void RoleList(string role)
        {
            role = Helper.AddString("Role").ToLower();

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
            var employeeId = Helper.AddInt("Input Employee Id");

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
