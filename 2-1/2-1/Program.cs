using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    internal class Program
    {
       public 
        static void Main(string[] args)
        {
            void Delimiter()
            {
                Console.WriteLine("**********************");
            }
            //Приветствие
            void Greetings()
            {
                Console.WriteLine("Привет, пользователь");
            }
            //Текущая дата.
            void Thecurrentdate()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(DateTime.Today);
                Console.ResetColor();//Сброс цвет текста
            }
            //Вывод 10 нечетных чисел
            void oddnumbers()
            {
                for (int i = 0; i <= 20; i++)
                    if (i % 2 != 0)
                        Console.WriteLine(i);
            }
            //Вывод числа Пи
            void PI()
            {
                Console.WriteLine(Math.PI);
            }
            //Результат 
            Delimiter();
            Greetings();
            Delimiter();
            PI();
            Delimiter();
            Thecurrentdate();
            Delimiter();
            oddnumbers();
            Console.ReadKey();
            }
       }
    
}
