using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variance
{
    public class Employee
    {
        public string   Name { get; set; }
    }

    public class Manager: Employee
    {
        public int TeamSize { get; set; }
    }

    public class Director: Manager
    {
        public string Department { get; set; }
    }
}
