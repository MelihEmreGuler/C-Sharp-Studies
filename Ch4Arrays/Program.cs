using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students1 = new string[3]; //bu tanımda kaç elemanlı olduğunu belirtmek zorundayım.

            string[] students2 = { "Melih", "Hatice", "Mustafa" };

            string[] students3;
            students3 = new string[3];
            //şeklinde 3 temel tanımlama tarzı var.

            students2[2] = "Mert"; // arrayin sınırları dışına çıkmak bir runtime hatasıdır.

            //çok boyutlu diziler
            //iki boyutlu dizilerde [satır,sütun] şeklinde boyutları yerleştiririz.
            //  string[,] regions = new string[7, 3]; //türkiyede 7 bölge var ve her bölge için 3 şehir tanımlamak istiyorum.

            string[,] regions2 ={{"", "", ""}, { "", "", "" },
            {"", "", ""}, { "", "", "" },
            {"", "", ""}, { "", "", "" },
            {"", "", ""}, { "", "", "" },
            };
            //diziyi açık tanımladıktan sonra sonuna noktalı virgül koymayı unutma

            for (int i = 0; i <= regions2.GetUpperBound(0); i++)
            {
                //GetUpperBound(0) içerisindeki "0" dizinin birinci boyutunu yani satırların sayısını bize verecektir
                for (int j = 0; j <= regions2.GetUpperBound(1); j++)
                {
                    //GetUpperBound(1) içerisindeki "1" dizinin birinci boyutunu yani sütunları sayısını bize verecektir
                    regions2[i, j] = "asdf";
                    Console.WriteLine(regions2[i, j]);
                }
                Console.WriteLine("************");
            }
            Console.ReadLine();
        }
    }
}
