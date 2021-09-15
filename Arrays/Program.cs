using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] numbers = new int[lines];
            for (int i = 0; i < lines; i++)
            {
                string str = Console.ReadLine();
                int sum = 0;

                foreach (var letter in str)
                {
                    switch (letter)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            sum += letter * str.Length;
                            break;
                        default:
                            sum += letter / str.Length;
                            break;
                    }
                }
                numbers[i] += sum;
            }
            Array.Sort(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
