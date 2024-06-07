using ClassInheritance;

Employee empl1 = new Employee("Петров","менеджер");
empl1.Info();
Console.WriteLine();

Manager manager1 = new Manager("Иванов","руководитель","отдел лингвистики");
manager1.Info();
Console.WriteLine();


void MakeSound(Animal animal)
{
    animal.MakeSound();
}
Dog dog = new Dog();
Cat cat = new Cat();
MakeSound(dog);
MakeSound(cat);

