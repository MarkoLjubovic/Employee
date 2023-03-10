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
            Console.WriteLine("Project:");
            Model.Project = Common.Validations.StringValidation();
            Console.WriteLine("IsStudent:");
            Model.IsStudent = Common.Validations.BoolValidation();
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
