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
    public class STService : BaseService<SoftwareTester>
    {
        public STService(SoftwareTester model) : base(model, Common.Constants.Role.ST)
        {
        }

        public override IEmployee AddEmployee()
        {
            base.AddEmployee();
            Model.Project = Helper.AddString("Project");
            Model.UsesAutomatedTests = Helper.AddBool("UsesAutomatedTests");
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
