using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CEOService:BaseService<CEO>
    {
        public CEOService(CEO model) : base(model, Common.Constants.Role.CEO)
        {
        }

        public override IEmployee AddEmployee()
        {
            base.AddEmployee();
            Console.WriteLine("CeoYears:");
            Model.CeoYears = Common.Validations.IntValidation();
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
