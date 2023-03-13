﻿using Common;
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

        public DSNRService(Designer model) : base(model, Common.Constants.Role.DSNR)
        {
        }

        public override IEmployee AddEmployee()
        {
            base.AddEmployee();
            Model.Project = Helper.AddString("Project");
            Model.CanDraw = Helper.AddBool("CanDraw");
            EmployeeStorage.Storage.AddEmployee(Model);

            return Model;
        }
    }
}
