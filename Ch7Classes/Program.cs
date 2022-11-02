using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Melih";
            Console.WriteLine(customer.Name);
            Console.ReadLine();
        }
    }
}
