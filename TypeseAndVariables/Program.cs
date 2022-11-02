using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeseAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //byte 8 bit yer kaplar
            byte byte1 = 255;
            //short 16 bit yer tutar
            short short1 = 32767;
            //int 32 bit yer tutar
            int number1 = 3;
            int number2 = 4;
            //long 64 bit yer tutar
            long number3 = 5;
            Console.WriteLine("number1 is {1}", number1, number2);

            double double1 = 10.4;
            decimal decimal1 = 1.456m;//kullanmak için sonuna m veya M koymamız gerekiyor.
            Console.WriteLine(decimal1);

            char char1, char2, char3, char4, char5;
            char1 = 'M';
            char2 = 'E';
            char3 = 'L';
            char4 = 'I';
            char5 = 'H';
            Console.WriteLine("Characters: {0},{1},{2},{3},{4}", (int)char1, (int)char2, (int)char3, (int)char4, (int)char5);

            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Sunday);

            var var1 = 10;
            Console.WriteLine(var1);
            
            
            
            if(var1 == 10)
            {
                Console.WriteLine(var1);

            }
            for(int i = 0; i > -1;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
        enum Days
        {
            Monday = 11, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, //eşittir ile index ini değiştirip oynama yapabiliyoruz
        }
    }
}
