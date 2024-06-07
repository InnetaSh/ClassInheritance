using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Наследование классов "Работник" и "Менеджер":

//Напишите базовый класс Employee с полями Name и Position.
//Напишите производный класс Manager, который добавляет поле Department.
//Создайте объекты обоих классов и выведите их данные.

namespace ClassInheritance
{
    public class Employee
    {
        public string Name;
        public string Position;
        public Employee(string name,string position)
        {
            Name = name;
            Position = position;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Имя - {Name},\nдолжность - {Position}");
        }
    }


}
