using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DEVService : BaseService<Developer>
    {
        private readonly Developer model;

        public DEVService(Developer model, string role) : base(model, role)
        {
            this.model = model;
            model.Role = role;
        }

        public void AddDeveloper()
        {
            AddEmployee();
            Console.WriteLine("Project:");
            model.Project = Common.Helper.AddString();
            Console.WriteLine("IsStudent:");
            model.IsStudent=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Id:{model.Id}, Role:{model.Role}, FirstName:{model.FirstName}, LastName: {model.LastName}, Age:{model.Age}, Project:{model.Project}, IsStudent:{model.IsStudent}");
        }
    }
}
