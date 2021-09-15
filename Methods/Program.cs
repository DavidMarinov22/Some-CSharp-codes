using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (isZero(num1, num2 ,num3))
            {
                Console.WriteLine("zero");
            }
            else if (isNegative(num1 ,num2 ,num3))
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }

        private static bool isNegative(int num1, int num2, int num3)
        {
            int minus = 0;
            if (num1 < 0)
            {
                minus++;
            }
            if (num2 < 0)
            {
                minus++;
            }
            if (num3 < 0)
            {
                minus++;
            }
            if (minus == 1 || minus == 3)
            {
                return true;
            }
            return false;
        }

        private static bool isZero(int num1, int num2, int num3)
        {
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
