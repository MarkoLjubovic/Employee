﻿using Interfaces;
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

        public DSNRService(Designer model) : base(model, "dsnr")
        {
        }

        public override IEmployee AddEmployee()
        {
            base.AddEmployee();
            Console.WriteLine("Project:");
            Model.Project = Common.Validations.StringValidation();
            Console.WriteLine("CanDraw:");
            Model.CanDraw = Common.Validations.BoolValidation();
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
