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
        public PMService(ProjectManager model) : base(model, "PM")
        {
        }

        public override IEmployee AddEmployee()
        {
            AddEmployee();
            Console.WriteLine("Project:");
            Model.Project = Common.Helper.AddString();
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
