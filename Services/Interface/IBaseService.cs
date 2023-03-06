using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IBaseService
    {
        IEmployee AddEmployee();
        bool RemoveEmployee();
        void EmployeeList();
        void RoleList();
        void EmployeeDisplay();
    }
}
