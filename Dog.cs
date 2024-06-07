using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassInheritance
{
    public class Dog :Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"Gav-gav!");
        }
    }
}
