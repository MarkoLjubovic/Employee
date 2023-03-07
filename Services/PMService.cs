using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PMService : BaseService<ProjectManager>
    {
        private readonly ProjectManager _model;
        public PMService(ProjectManager model, string role) : base(model, role)
        {
            _model = model;
            _model.Role = role;
        }

        public void AddProjectManager()
        {
            AddEmployee();
            Console.WriteLine("Project:");
            _model.Project = Common.Helper.AddString();
        }
    }
}
