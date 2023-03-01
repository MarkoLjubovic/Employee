using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICommands
    {
        public void Help();
        public void Add();
        public void Remove();
        public void Display();
        public void List();
        public void List<T>();
    }
}
