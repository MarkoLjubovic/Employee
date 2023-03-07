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
        private readonly Designer _model;

        public DSNRService(Designer model, string role) : base(model, role)
        {
            _model = model;
            _model.Role = role;
        }

        public void AddDSNR()
        {
            AddEmployee();
            Console.WriteLine("Project:");
            _model.Project = Common.Helper.AddString();
            Console.WriteLine("CanDraw:");
            _model.CanDraw = Common.Helper.AddBool();
        }
    }
}
