using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DSNRService:BaseService<Designer>
    {

        public DSNRService(Designer model) : base(model, "DSNR")
        {
        }

        public override IEmployee AddEmployee()
        {
            AddEmployee();
            Console.WriteLine("Project:");
            Model.Project = Common.Helper.AddString();
            Console.WriteLine("CanDraw:");
            Model.CanDraw = Common.Helper.AddBool();
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
