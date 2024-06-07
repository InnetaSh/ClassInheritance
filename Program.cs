using ClassInheritance;

Employee empl1 = new Employee("Петров", "менеджер");
empl1.Info();
Console.WriteLine();


Manager manager1 = new Manager("Иванов", "руководитель", "отдел лингвистики");
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
Console.WriteLine();



BankAccount account = new BankAccount(1500, "Иван");
account.Info();

account.Deposite();
account.Info();

Console.WriteLine();

account.TryGetMoney();
account.Info();
Console.WriteLine();



Counter count1 = new Counter(15);
count1.Info();

Counter count2 = new Counter(20);
count2.Info();
count2.Increment();
count2.Increment();
count2.Info();

Counter count3 = new Counter(25);
count3.Info();
count3.Decrement();
count3.Decrement();
count3.Info();


