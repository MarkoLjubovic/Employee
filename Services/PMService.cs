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
    public class PMService : BaseService<ProjectManager>
    {
        public PMService(ProjectManager model) : base(model, Common.Constants.Role.PM)
        {
        }

        public override IEmployee AddEmployee()
        {
            base.AddEmployee();
            Model.Project = Helper.AddString("Project");
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
