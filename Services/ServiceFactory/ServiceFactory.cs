using Common;
using Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceFactory
{
    public class ServiceFactory
    {
        private static IBaseService service;

        public static IBaseService GetService(string role)
        {
            service = null;
            switch (role)
            {
                case Constants.Role.CEO:
                    service = new CEOService(new CEO());
                    break;
                case Constants.Role.DEV:
                    service = new DEVService(new Developer());
                    break;
                case Constants.Role.DSNR:
                    service = new DSNRService(new Designer());
                    break;
                case Constants.Role.PM:
                    service = new PMService(new ProjectManager());
                    break;
                case Constants.Role.ST:
                    service = new STService(new SoftwareTester());
                    break;
                case Constants.Role.BASE:
                    service = new BaseService<Employee>(new Employee(), null);
                    break;
            }
            return service;
        }
    }
}
