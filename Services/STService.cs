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
        public STService(SoftwareTester model) : base(model, "ST")
        {
        }

        public override IEmployee AddEmployee()
        {
            AddEmployee();
            Console.WriteLine("Project:");
            Model.Project = Common.Helper.AddString();
            Console.WriteLine("UsesAutomatedTests:");
            Model.UsesAutomatedTests=Common.Helper.AddBool();
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
