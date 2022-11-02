using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string bir char array dir
            string string1 = "Melih";
            foreach(char c in string1)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("***********************");

            string string2 = "Emre";
            
            string string3 = string1 + string2;
            Console.WriteLine(string3);

            Console.WriteLine("***********************");

            string sentence = "Hello My Name Is Melih";

            int index = sentence.IndexOf("My"); //bulduğu ilk index i geri döndürür.
                                                //bulamadığı değerlerde -1 döndürür.
            Console.WriteLine(index);

            int index2 = sentence.LastIndexOf(" ");//aramaya sondan başlar 
            Console.WriteLine(index2);

            sentence.Insert(0, "Hello, "); //stringimin 0. indisinden itibaren "Hello, " stringini yerleştir
            Console.WriteLine(sentence);

            sentence = sentence.Substring(5); //stringimin 5. karakterinden itibaren al demek
            Console.WriteLine(sentence);

            sentence = sentence.Substring(5, 2);//stringimin 5. karakterinden itibaren 2 sadece karekter al demek
            Console.WriteLine(sentence);

            sentence = "Hello My Name Is Melih";

            sentence = sentence.ToLower(); //stringimin bütün karakterilerini küçüğe çevir.
            Console.WriteLine(sentence);

            sentence = sentence.ToUpper(); //stringimin bütün karakterilerini küçüğe çevir.
            Console.WriteLine(sentence);

            sentence = sentence.Replace(" ", "-"); //stringimin içerisindeki bütün boşlukları kısa çizgi ile değiştir.
            Console.WriteLine(sentence);

            sentence = sentence.Remove(11); //stringimin içerisindeki 11. indisten itibaren sil.
            Console.WriteLine(sentence);

            sentence = sentence.Remove(5, 4); //stringimin içerisindeki 5. indisten itibaren 4 tane sil gerisi dursun.
            Console.WriteLine(sentence);

            Console.ReadLine();
        }
    }
}
