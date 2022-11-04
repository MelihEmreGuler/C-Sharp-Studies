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
            Console.WriteLine("Method cagirildiktan sonraki degeri: " + number1);

            Console.WriteLine("***********************");

            Console.WriteLine("ilk degeri: " + number1);
            refMethod(ref number1);
            Console.WriteLine("Method cagirildiktan sonraki degeri: " + number1);

            Console.WriteLine("***********************");

            int result = Add(4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine("result: "+ result);

            Console.ReadLine();

        }

        // deger tiplerinin de method icerisinde degerinin degismesini istiyorsak onlarin parametrelerine ref key'ini ekliyoruz.
        static void refMethod(ref int number1)
        {
            number1 += 10;
        }
        //deger tiplerinde ilk tanimlama yapmadan method icerisinde ilk degerini atamak istiyorsak ref yerine out key'ini kullaniyoruz.
        static void outMethod(out int number1)
        {
            number1 = 50; //eger bu sekilde bir deger set etmezsek hata aliriz cunku o degisken degersiz kalir.
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

        //params key'i (sinirsiz parametre) 
        //params, kullanildigi methodun son parametresi olmak zorunda
        static int Add(params int[] numbers)
        {
            return numbers.Sum(); //Sum methodu hazir gelen bir toplama metodu.
        }
    }
}
