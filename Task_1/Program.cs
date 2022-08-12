using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.    Создать класс для моделирования счета в банке. 
 * Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
 * Класс должен быть объявлен как обобщенный. 
 * Универсальный параметр T должен определять тип номера счета. 
 * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
 * Создать  несколько экземпляров класса, параметризированного различными типам. 
 * Заполнить его поля и вывести информацию об экземпляре класса на печать.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тест 1
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.SetInfo();
            Console.WriteLine(bankAccount1.GetInfo());

            //Тест 2
            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.SetInfo();
            Console.WriteLine(bankAccount2.GetInfo());

            Console.ReadKey();
        }
    }
}
