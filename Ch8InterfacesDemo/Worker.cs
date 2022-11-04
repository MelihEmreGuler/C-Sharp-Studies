using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8InterfacesDemo
{
    internal class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Calisan Yemek Yedi.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Calisan Maas Aldi.");
        }

        public void Work()
        {
            Console.WriteLine("Calisan Calisti.");
        }
    }
}
