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
        //void Help(string role);
        void Add(string role);
        void RoleList(string role);
        void Display();
        void Remove();
        void List();
    }
}
