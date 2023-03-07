﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DEVService : BaseService<Developer>
    {
        private readonly Developer _model;

        public DEVService(Developer model, string role) : base(model, role)
        {
            _model = model;
            _model.Role = role;
        }

        public void AddDeveloper()
        {
            AddEmployee();
            Console.WriteLine("Project:");
            _model.Project = Common.Helper.AddString();
            Console.WriteLine("IsStudent:");
            _model.IsStudent=Convert.ToBoolean(Console.ReadLine());
        }
    }
}
