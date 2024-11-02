using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructors
{
    public class Employee(int age, string name, decimal salary, IEnumerable<string> telephones)
    {
        public Employee(int age, string name, decimal salary) : this(age, name, salary, Enumerable.Empty<string>()) { }
        
        public int Age => age;
        public string Name { get; set; } = name;
        public decimal Salary { get; set; } = Math.Round(salary, 2);

        public void DsplayTelephones()
        {
            foreach (var telephone in telephones)
            {
                Console.WriteLine(telephone);
            }
        }
        
    }
}
