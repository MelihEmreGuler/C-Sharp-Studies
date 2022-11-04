using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary 
        //bir class birden fazla class'ı iplemente edebilir.
    {
        public void Eat()
        {
            Console.WriteLine("Manager Yemek Yedi.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Maas Aldi.");
        }

        public void Work()
        {
            Console.WriteLine("Manager Calisti.");
        }
    }
}
