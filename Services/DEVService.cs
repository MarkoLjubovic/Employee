using Common;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DEVService : BaseService<Developer>
    {
        public DEVService(Developer model) : base(model, Common.Constants.Role.DEV)
        {
        }

        public override IEmployee AddEmployee()
        {
            base.AddEmployee();
            Model.Project = Helper.AddString("Project");
            Model.IsStudent = Helper.AddBool("IsStudent");
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
