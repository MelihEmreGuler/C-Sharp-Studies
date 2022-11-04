using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] {
                new Manager(),
                new Worker(),
                new Robot(),
            };

            foreach(var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };

            foreach(var eater in eats)
            {
                eater.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker(),
            };

            foreach(var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
        }
    }
}
