using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class STService : BaseService<SoftwareTester>
    {
        public STService(SoftwareTester model) : base(model, Common.Constants.Role.ST)
        {
        }

        public override IEmployee AddEmployee()
        {
            base.AddEmployee();
            Console.WriteLine("Project:");
            Model.Project = Common.Validations.StringValidation();
            Console.WriteLine("UsesAutomatedTests:");
            Model.UsesAutomatedTests = Common.Validations.BoolValidation();
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
