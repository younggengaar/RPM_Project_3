using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РПМ_Практическая_работа_3
{
    internal class Program
    {
        static void Main()
        {
            int n = 5;
            long result = CalculateFactorial(n);
            Console.WriteLine($"Факториал числа {n} равен {result}");
            Console.ReadKey();
        }

        static long CalculateFactorial(int number)
        {
            // Базовый случай: факториал 0 и 1 равен 1
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                // Рекурсивный случай: n! = n * (n-1)!
                return number * CalculateFactorial(number - 1);
            }
        }
    }
}
