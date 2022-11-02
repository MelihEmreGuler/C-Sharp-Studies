using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ch8Interfaces.OracleCustomerDal;

namespace Ch8Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir interface nesnesi hicbir zaman olusturulamaz cunu tek basina hicbir anlami yoktur.
            //abstrac class ve interface'leri new lemek mümkün değildir.
            PersonManager manager = new PersonManager();


            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirsName = "Melih",
            //    LastName = "Guler",
            //    Address = "Istanbul"
            //}; //bu gosterim de mevcut (constructor kullanimina benziyor)
            Student student = new Student
            {
                Id = 1,
                FirsName = "Emre",
                LastName = "Guler",
                Departmant = "Computer Science",
            };

            manager.Add(new Customer { Id = 1, FirsName = "Melih", LastName = "Guler", Address = "Istanbul" });
            manager.Add(student);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
            };

            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }
        interface IPerson // diger class lari bundan iplemente edeceğiz
        {
            int Id { get; set; }
            String FirsName { get; set; }
            String LastName { get; set; }

        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public String FirsName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }

        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public String FirsName { get; set; }
            public string LastName { get; set; }
            
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)//veri tabanina musteri kaydetmek gibi dusunelim
            {
                Console.WriteLine(person.FirsName);
            }
        }
    }
}
