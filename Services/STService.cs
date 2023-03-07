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
        private readonly SoftwareTester _model;
        public STService(SoftwareTester model, string role) : base(model, role)
        {
            _model = model;
            _model.Role = role;
        }

        public void AddSoftwareTester()
        {
            AddEmployee();
            Console.WriteLine("Project:");
            _model.Project = Common.Helper.AddString();
            Console.WriteLine("UsesAutomatedTests:");
            _model.UsesAutomatedTests=Common.Helper.AddBool();
        }
    }
}
