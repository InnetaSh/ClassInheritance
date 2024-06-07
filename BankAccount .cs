using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassInheritance
{
    public class BankAccount
    {
        private static int accountNumber = 0;
        public double Balance;
        public string Owner;

        public static int AccountNumber
        {
            get
            {
               return accountNumber;
            }
            private set
            {
                accountNumber = value;
            }
        }

        public BankAccount(double balance, string owner)
        {
            Balance = balance;
            Owner = owner;
            AccountNumber++;
        }

        public void Deposite()
        {
            Console.WriteLine("Введите сумму, которую хотите положить на депозит.");
            double money;
            while (!Double.TryParse(Console.ReadLine(), out money) || money <= 0)
                Console.WriteLine("Не верный ввод.Введите сумму, которую хотите положить на депозит.");
            Balance += money;
        }


        public void TryGetMoney()
        {
            Console.WriteLine("Введите сумму, которую хотите снять со счета.");
            double money;
            while (true)
            {
                if (!Double.TryParse(Console.ReadLine(), out money) || money <= 0)
                {
                    Console.WriteLine("Не верный ввод.Введите сумму, которую хотите снять со счета.");
                    continue;
                }
                if (Balance < money)
                {
                    Console.WriteLine($"Не достаточно средств на счету.Введите сумму меньшую {Balance}.");
                    continue;
                }
                GetMoney(money);
                break;
            }
        }
        public void GetMoney(double money)
        {
            Balance -= money;
        }

        public void Info()
        {
            Console.WriteLine($"Номер акаунта - {AccountNumber},\tИмя - {Owner},\tбаланс - {Balance}");
        }
    }
}
