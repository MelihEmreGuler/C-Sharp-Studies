using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Interfaces
{
     public interface ICustomerDal
     {
        void Add();
        void Update();
        void Delete();

     }
    public class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    public class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }

        public class CustomerManager //udemy de bunu public yapmadan Program.cs den erisebiliyordu
        {
            public void Add(ICustomerDal customerDal)
            {
                customerDal.Add();
            }
        }
    }
}
