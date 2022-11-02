using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Classes
{
    internal class Customer
    {
        //bu bir field'tir
        int id1;
        //bu bir property(özellik)' tir.
        //encapsulation tekniklerini uygulamak için kullanılır.
        //bir field üzerinde değeri verirken ya da okurken oynama yapmak istediğimiz zaman bu formatı kullanırırz
        public int id { get; set; }
        private string _name;
        public string Name {
            get
            {
                return "Mr." + _name; //arka planda dolu olan name değerinin üzerinde istediğimiz gibi oynama yapıp geri döndürebiliriz.
            }
            set
            {
                _name = value; // tanımlarken gönderilen value değerini _name nin içerisine koy. 
            }
        }
    }
}
