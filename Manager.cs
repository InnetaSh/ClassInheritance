using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    public class Manager : Employee
    {
        public string Department;

        public Manager(string name, string position,string departament):base(name,position)
        {
            Department = departament;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя - {Name},\nдолжность - {Position}\nдепартамент - {Department}");
        }
    }
   
}
