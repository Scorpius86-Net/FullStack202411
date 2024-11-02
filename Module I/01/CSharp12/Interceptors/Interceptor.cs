using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interceptors
{
    public static class Interceptor
    {
        [InterceptsLocation("Program.cs", line: 11, column: 18)]
        [InterceptsLocation("Program.cs", line: 13, column: 18)]
        public static void InterceptorDisplay(this Employee employee, string name)
        {
            Console.WriteLine($"Interceptor Display {name}");
        }
    }
}
