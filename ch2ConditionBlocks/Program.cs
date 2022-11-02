using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2ConditionBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int1 = 10;
            Console.WriteLine(int1 == 10 ? "Number is 10" : "Number is not 10");
            Console.ReadLine();

            switch (int1)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 11:
                    Console.WriteLine("Number is 11");
                    break;
                default:
                    Console.WriteLine("Number has a different value");
                    break; //default u bile break ile sonlandırmak zorundayız.

            }
        }
    }
}
