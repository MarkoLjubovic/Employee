using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Commands : ICommands
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Help()
        {
            Console.WriteLine("Dostupne uloge su CEO, Designer, Developer, ProjectManager i SoftwareTester.");
        }

        public void List()
        {
            throw new NotImplementedException();
        }

        public void List<T>()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
