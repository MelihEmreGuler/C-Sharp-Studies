using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ii = 0;
            while(ii < 5)
            {
                Console.WriteLine(ii);
                ii++;
            }

            int jj = 0;
            do
            {
                Console.WriteLine(jj);
                jj++;
            }while(jj < 5);


            string[,] regions2 ={{"", "", ""}, { "", "", "" },
            {"", "", ""}, { "", "", "" },
            {"", "", ""}, { "", "", "" },
            {"", "", ""}, { "", "", "" },
            };
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

            foreach(var region in regions2)
            {
                //region = "asd"; foreach içerisinde döngü elemanı değiştiremem düzenleyemem bunun için for döngüsü lazım.
                Console.WriteLine(region);
            }

            Console.ReadLine();

        }
    }
}
