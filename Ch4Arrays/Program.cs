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
            string[] students1 = new string[3]; //bu tanimda kac elemanli oldugunu belirtmek zorundayim.

            string[] students2 = { "Melih", "Hatice", "Mustafa" };

            string[] students3;
            students3 = new string[3];
            //seklinde 3 temel tanimlama tarzi var.

            students2[2] = "Mert"; // arrayin sinirlari disina cikmak bir runtime hatasidir.

            //cok boyutlu diziler
            //iki boyutlu dizilerde [satir,sutun] seklinde boyutlari yerlestiririz.
            //  string[,] regions = new string[7, 3]; //turkiyede 7 bolge var ve her bolge icin 3 sehir tanimlamak istiyorum.

            string[,] regions2 ={{"", "", ""}, { "", "", "" },
            {"", "", ""}, { "", "", "" },
            {"", "", ""}, { "", "", "" },
            {"", "", ""}, { "", "", "" },
            };
            //diziyi acik tanimladiktan sonra sonuna noktali virgul koymayi unutma

            for (int i = 0; i <= regions2.GetUpperBound(0); i++)
            {
                //GetUpperBound(0) icerisindeki "0" dizinin birinci boyutunu yani satirlarin sayisini bize verecektir
                for (int j = 0; j <= regions2.GetUpperBound(1); j++)
                {
                    //GetUpperBound(1) icerisindeki "1" dizinin birinci boyutunu yani sutunlari sayisini bize verecektir
                    regions2[i, j] = "asdf";
                    Console.WriteLine(regions2[i, j]);
                }
                Console.WriteLine("************");
            }
            Console.ReadLine();
        }
    }
}
