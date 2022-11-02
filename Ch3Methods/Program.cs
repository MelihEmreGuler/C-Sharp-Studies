using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            Console.WriteLine("ilk degeri: " + number1);
            refMethod(ref number1);
            Console.WriteLine("Method çağırıldıktan sonraki değeri: " + number1);

            Console.WriteLine("***********************");

            Console.WriteLine("ilk degeri: " + number1);
            refMethod(ref number1);
            Console.WriteLine("Method çağırıldıktan sonraki değeri: " + number1);

            Console.WriteLine("***********************");

            int result = Add(4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine("result: "+ result);

            Console.ReadLine();

        }

        // değer tiplerinin de method içerisinde değerinin değişmesini istiyorsak onların parametrelerine ref key'ini ekliyoruz.
        static void refMethod(ref int number1)
        {
            number1 += 10;
        }
        //değer tiplerinde ilk tanımlama yapmadan method içerisinde ilk değerini atamak istiyorsak ref yerine out key'ini kullanıyoruz.
        static void outMethod(out int number1)
        {
            number1 = 50; //eğer bu şekilde bir değer set etmezsek hata alırız çünkü o değişken değersiz kalır.
        }

        //method overloading
        static int Multiplay(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiplay(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params key'i (sınırsız parametre) 
        //params, kullanıldığı methodun son parametresi olmak zorunda
        static int Add(params int[] numbers)
        {
            return numbers.Sum(); //Sum methodu hazır gelen bir toplama metodu.
        }
    }
}
