using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptors
{
    public class Employee
    {
        public void Display(string name)
        {
            Console.WriteLine($"Displaying {name}");
        }
        
    }
}
