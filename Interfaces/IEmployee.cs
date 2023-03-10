using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEmployee
    {
        Guid Guid { get; set; }
        int Id { get; set; }
        string Role { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

        string FullInfo();
    }
}
