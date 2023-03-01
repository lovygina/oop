using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //realnumbers
            Console.WriteLine("Введите число А");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число В");
            int B = int.Parse(Console.ReadLine());
            //Сумма двух действительных числа
            void Sum()
            {
               Console.WriteLine("Сумма:");
               Console.WriteLine($"{A + B}");
            }
            //
            void Difference()
            {
                Console.WriteLine("Разность:");
                Console.WriteLine($"{A - B}");
            }
            void gipotenyza()
            {
                Console.WriteLine("Гипотенуза");
                int K = (A * A) + (B * B);
                Console.WriteLine($"{Math.Sqrt(K)}");
            }
            Sum();
            Difference();
            gipotenyza();
            Console.ReadKey();
        }   

    }
}
