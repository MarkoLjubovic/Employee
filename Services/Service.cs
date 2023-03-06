using EmployeeStorage;
using Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Service : IService
    {
        protected readonly IBaseService _baseService;
        public Service(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public void Help(List<Employee> employees)
        {
            Console.WriteLine("Available commands: 1. Add, 2. Remove, 3. Display, 4. List, 5. CEOList, 6. DSNRList");
            Console.WriteLine("Pick one:");
            var unos = Console.ReadLine();
            unos = unos.ToLower();

            switch (unos)
            {
                case "add":
                    Add(employees);
                    break;

                case "remove":
                    Remove();
                    Help(employees);
                    break;

                case "display":
                    Display();
                    Help(employees);
                    break;

                case "list":
                    List();
                    Help(employees);
                    break;

                case "ceo":
                    List();
                    Help(employees);
                    break;

                case "dsnr":
                    List();
                    Help(employees);
                    break;
            }
        }
        public void AddCEO(CEO cEO)
        {
            Console.WriteLine("FirstName:");
            cEO.FirstName = Console.ReadLine();
            Console.WriteLine("LastName:");
            cEO.LastName = Console.ReadLine();
            Console.WriteLine("Age:");
            cEO.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CeoYears:");
            cEO.CeoYears = Convert.ToInt32(Console.ReadLine());
        }
        public void AddDesigner(List<Designer> designers)
        {
            Designer designer = new Designer();
            Console.WriteLine("FirstName:");
            designer.FirstName = Console.ReadLine();
            Console.WriteLine("LastName:");
            designer.LastName = Console.ReadLine();
            Console.WriteLine("Age:");
            designer.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project:");
            designer.Project = Console.ReadLine();
            Console.WriteLine("CanDraw:");
            designer.CanDraw = Convert.ToBoolean(Console.ReadLine());
            designers.Add(designer);
            DSNRList(designers);
        }
        public void AddDeveloper(List<Developer> developers)
        {
            Developer developer = new Developer();
            Console.WriteLine("FirstName:");
            developer.FirstName = Console.ReadLine();
            Console.WriteLine("LastName:");
            developer.LastName = Console.ReadLine();
            Console.WriteLine("Age:");
            developer.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project:");
            developer.Project = Console.ReadLine();
            Console.WriteLine("IsStudent:");
            developer.IsStudent = Convert.ToBoolean(Console.ReadLine());
            developers.Add(developer);
            DEVList(developers);
        }
        public void AddProjectManager(List<ProjectManager> projectManagers)
        {
            ProjectManager projectManager = new ProjectManager();
            Console.WriteLine("FirstName:");
            projectManager.FirstName = Console.ReadLine();
            Console.WriteLine("LastName:");
            projectManager.LastName = Console.ReadLine();
            Console.WriteLine("Age:");
            projectManager.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project:");
            projectManager.Project = Console.ReadLine();
            projectManagers.Add(projectManager);
        }
        public void AddSoftwareTester(List<SoftwareTester> softwareTesters)
        {
            SoftwareTester softwareTester = new SoftwareTester();
            Console.WriteLine("FirstName:");
            softwareTester.FirstName = Console.ReadLine();
            Console.WriteLine("LastName:");
            softwareTester.LastName = Console.ReadLine();
            Console.WriteLine("Age:");
            softwareTester.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project:");
            softwareTester.Project = Console.ReadLine();
            Console.WriteLine("UsesAutomatedTests:");
            softwareTester.UsesAutomatedTests = Convert.ToBoolean(Console.ReadLine());
            softwareTesters.Add(softwareTester);
        }
        public void Add(List<Employee> employees)
        {
            Console.WriteLine("Option Add is picked.");
            Console.WriteLine("Available roles: CEO, PM, DEV, DSNR, ST. Pick role you want to input:");
            var unos = Console.ReadLine().ToLower();

            switch (unos)
            {
                case "ceo":
                    Add(employees);
                    Help(employees);
                    break;

                case "dsnr":
                    Add(employees);
                    Help(employees);
                    break;

                case "dev":
                    Add(employees);
                    Help(employees);
                    break;

                case "pm":
                    Add(employees);
                    Help(employees);
                    break;

                case "st":
                    Add(employees);
                    Help(employees);
                    break;
            }
        }

        public void CEOList(CEO cEO)
        {
            Console.WriteLine($"FirstName: {cEO.FirstName}, LastName:{cEO.LastName}, Age:{cEO.Age}, CeoYears:{cEO.CeoYears}");
        }

        public void DEVList(List<Developer> developers)
        {
            throw new NotImplementedException();
        }

        public void DSNRList(List<Designer> designers)
        {
            Console.WriteLine("List of designers:");
            foreach (var dsnr in designers)
            {
                Console.WriteLine($"FirstName: {dsnr.FirstName}, LastName:{dsnr.LastName}, Age:{dsnr.Age}, Project:{dsnr.Project}, CanDraw:{dsnr.CanDraw}");
            }
        }

        public void PMList(List<ProjectManager> projectManagers)
        {
            throw new NotImplementedException();
        }

        public void STList(List<SoftwareTester> softwareTesters)
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            _baseService.RemoveEmployee();
        }

        public void Display()
        {
            _baseService.EmployeeDisplay();
        }

        public void List()
        {
            _baseService.EmployeeList();
        }
    }

}
