using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IService
    {
        void Help(CEO cEO, List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters);
        void Add(CEO cEO, List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters);
        void Remove(CEO cEO, List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters);
        void Display(CEO cEO, List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters);
        void List(List<Designer> designers, List<Developer> developers, List<ProjectManager> projectManagers, List<SoftwareTester> softwareTesters);
        void CEOList(CEO cEO);
        void PMList(List<ProjectManager> projectManagers);
        void DEVList(List<Developer> developers);
        void DSNRList(List<Designer> designers);
        void STList(List<SoftwareTester> softwareTesters);
        void AddCEO(CEO cEO);
        void AddDesigner(List<Designer> designers);
        void AddDeveloper(List<Developer> developers);
        void AddProjectManager(List<ProjectManager> projectManagers);
        void AddSoftwareTester(List<SoftwareTester> softwareTesters);
    }
}
