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
        private readonly CEO _model;

        public CEOService(CEO model, string role) : base(model, role)
        {
            _model = model;
            _model.Role = role;
        }

        public void AddCEO()
        {
            AddEmployee();
            Console.WriteLine("CeoYears:");
            _model.CeoYears = Common.Helper.AddInt();
            Console.WriteLine("CeoYears:");
            _model.CeoYears = Common.Helper.AddInt();
        }
    }
}
