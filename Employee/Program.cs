using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CEO cEO = new CEO();
            Developer developer = new Developer();
            ProjectManager projectManager = new ProjectManager();
            SoftwareTester softwareTester = new SoftwareTester();

            Service s=new Service();
            Storage storage = new Storage();
            s.Help(cEO,storage.designers,storage.developers,storage.projectManagers,storage.softwareTesters);
        }
    }
}
