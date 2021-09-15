using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            bool isBalanced = true;
            int openingBra = 0;
            int closingBra = 0;
            int brackets = 0;
            bool isBreak = false;

            for (int i = 0; i < lines; i++)
            {
                string str = Console.ReadLine();
                if (str == ")")
                {

                }
            }
            if (openingBra != closingBra || isBreak)
            {
                isBalanced = false;
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
