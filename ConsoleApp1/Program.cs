using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите число n : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Все нечетные числа до числа n: ");

            for (int i = 0; i <= n; i++) 
            {
                if (i % 2 != 0) 
                {
                    sum = sum+i;
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Сумма всех нечетных чисел до числа n равна " + sum);
            Console.ReadKey();

        }
    }
}
