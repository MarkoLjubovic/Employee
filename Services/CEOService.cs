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
        private readonly CEO model;

        public CEOService(CEO model, string role) : base(model, role)
        {
            this.model = model;
            model.Role = role;
        }

        public void AddCEO()
        {
            AddEmployee();
            Console.WriteLine("CeoYears:");
            model.CeoYears = Common.Helper.AddInt();
            Common.Helper.DisplayEmployees(model);
        }
    }
}
