using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.IStorage
{
    public interface IStorage
    {
        IEmployee AddEmployee<T>(T employee) where T : IEmployee;
        bool RemoveEmployee(IEmployee employee);
        List<IEmployee> Employees();
        List<IEmployee> FindRole(string role);
        List<IEmployee> FindDifferentRole(string role);
        bool SearchRole(string role);
    }
}
