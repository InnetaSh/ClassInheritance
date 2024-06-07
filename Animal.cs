using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Полиморфизм с помощью метода "Звук":
//Напишите базовый класс Animal с методом MakeSound.
//Создайте производные классы Dog и Cat, которые переопределяют метод MakeSound.
//Напишите метод, который принимает объект типа Animal и вызывает его метод MakeSound.

namespace ClassInheritance
{
    public class Animal
    {
        public virtual void MakeSound()
        {

        }
    }
}
