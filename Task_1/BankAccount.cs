using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class BankAccount <T>
    {
        T accountNumber;
        double accountBalance;
        string accountOwner;

        public void SetInfo()
        {
            Console.WriteLine("Введите номер банковского счета");
            accountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс банковского счета");
            accountBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите имя владельца банковского счета");
            accountOwner = Console.ReadLine();
        }

        public string GetInfo()
        {
            return $"Банковский счет номер {accountNumber}" + "\n" + $"Владелец счета: {accountOwner}" + "\n" + $"Баланс: {accountBalance}";
        }
    }
}
