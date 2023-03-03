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
        Storage storage = new Storage();
        public void Help(CEO cEO, List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters)
        {
            Console.WriteLine("Available commands: 1. Add, 2. Remove, 3. Display, 4. List, 5. CEOList, 6. DSNRList");
            Console.WriteLine("Pick one:");
            var unos = Console.ReadLine();
            unos = unos.ToLower();

            switch (unos)
            {
                case "add":
                    Add(cEO, designers, developers, projectManagers, softwareTesters);
                    break;

                case "remove":
                    Remove(cEO, designers, developers, projectManagers, softwareTesters);
                    Help(cEO, designers, developers, projectManagers, softwareTesters);
                    break;

                case "display":
                    Display(cEO, designers, developers, projectManagers, softwareTesters);
                    Help(cEO, designers, developers, projectManagers, softwareTesters);
                    break;

                case "list":
                    List(designers, developers, projectManagers, softwareTesters);
                    Help(cEO, designers, developers, projectManagers, softwareTesters);
                    break;

                case "ceo":
                    CEOList(cEO);
                    Help(cEO, designers, developers, projectManagers, softwareTesters);
                    break;

                case "dsnr":
                    DSNRList(designers);
                    Help(cEO, designers, developers, projectManagers, softwareTesters);
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
            storage.projectManagers.Add(projectManager);
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
            storage.softwareTesters.Add(softwareTester);
        }
        public void Add(CEO cEO, List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters)
        {
            Console.WriteLine("Option Add is picked.");
            Console.WriteLine("Available roles: CEO, PM, DEV, DSNR, ST. Pick role you want to input:");
            var unos = Console.ReadLine().ToLower();

            switch (unos)
            {
                case "ceo":
                    AddCEO(cEO);
                    Help(cEO, designers, developers, projectManagers, softwareTesters);
                    break;

                case "dsnr":
                    AddDesigner(designers);
                    Help(cEO, designers, developers, projectManagers, softwareTesters);
                    break;

                case "dev":
                    AddDeveloper(developers);
                    Help(cEO, designers, developers, projectManagers, softwareTesters);
                    break;

                case "pm":
                    AddProjectManager(projectManagers);
                    Help(cEO, designers, developers, projectManagers, softwareTesters);
                    break;

                case "st":
                    AddSoftwareTester(softwareTesters);
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

        public void Remove(CEO cEO, List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters)
        {
            Console.WriteLine("Pick user role you want to delete.");
            var unos = Console.ReadLine().ToLower();
            switch (unos)
            {
                case "dsnr":
                    Console.WriteLine("FirstName:");
                    var firstName = Console.ReadLine();
                    Console.WriteLine("LastName:");
                    var lastName = Console.ReadLine();

                    foreach (var design in storage.designers)
                    {
                        if (firstName.Equals(design.FirstName) && lastName.Equals(design.LastName))
                        {
                            designers.Remove(design);
                            break;
                        }
                    }
                    DSNRList(designers);
                    break;
            }
        }

        public void Display(CEO cEO, List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters)
        {
            Console.WriteLine("List of employees");
            Console.WriteLine($"FirstName: {cEO.FirstName}, LastName:{cEO.LastName}, Age:{cEO.Age}");
            foreach (var dsnr in designers)
            {
                Console.WriteLine($"FirstName: {dsnr.FirstName}, LastName:{dsnr.LastName}, Age:{dsnr.Age}");
            }
            foreach (var dev in developers)
            {
                Console.WriteLine($"FirstName: {dev.FirstName}, LastName:{dev.LastName}, Age:{dev.Age}");
            }
            foreach (var pm in projectManagers)
            {
                Console.WriteLine($"FirstName: {pm.FirstName}, LastName:{pm.LastName}, Age:{pm.Age}");
            }
            foreach (var st in softwareTesters)
            {
                Console.WriteLine($"FirstName: {st.FirstName}, LastName:{st.LastName}, Age:{st.Age}");
            }
        }

        public void List(List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters)
        {
            throw new NotImplementedException();
        }
    }

}
