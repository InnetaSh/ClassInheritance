using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Статические члены класса "Счетчик":
//Напишите класс Counter с полем Value и статическим полем Count.
//Реализуйте методы для увеличения и уменьшения значения счетчика.
//Создайте несколько объектов класса и проверьте значение статического поля.

namespace ClassInheritance
{
    public class Counter
    {
        public int Value;
        public static int count = 0;

        public static int Count
        {
            get
            {
                return count;
            }
            private set
            {
                count = value;
            }
        }

        public Counter(int value)
        {
            Value = value;
            Count++;
        }

        public void Increment()
        {
            Value++;
        }

        public void Decrement()
        {
            Value--;
        }
        public void Info()
        {
            Console.WriteLine($"Значение - {Value},\tсчетик - {Count}");
        }

    }
}
