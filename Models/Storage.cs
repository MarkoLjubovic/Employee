using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Storage
    {

        public List<Designer> designers = new List<Designer>
        {
            new Designer{FirstName="Ivan", LastName="Ivancic", Age=26, Project="gfd", CanDraw=true},
            new Designer{FirstName="Ivana", LastName="Ivic", Age=22, Project="ghfg", CanDraw=true}
        };

        public List<Developer> developers = new List<Developer>
        {
            new Developer{FirstName="Ivan", LastName="Ivancic", Age=26, Project="gfd", IsStudent=true},
            new Developer{FirstName="Ivana", LastName="Ivancic", Age=22, Project="ghfg", IsStudent=true}
        };

        public List<ProjectManager> projectManagers = new List<ProjectManager>
        {
            new ProjectManager{FirstName="Ivan", LastName="Ivancic", Age=26, Project="gfd"},
            new ProjectManager{FirstName="Ivana", LastName="Ivancic", Age=22, Project="ghfg"}
        };

        public List<SoftwareTester> softwareTesters = new List<SoftwareTester>
        {
            new SoftwareTester{FirstName="Ivan", LastName="Ivancic", Age=26, Project="gfd", UsesAutomatedTests=true},
            new SoftwareTester{FirstName="Ivana", LastName="Ivancic", Age=22, Project="ghfg", UsesAutomatedTests=false}
        };
    }
}
