using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Mesut";
            //students[2] = "Umut";


            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.ReadLine();

            //string[] students2 = new[] { "Engin", "Mesut", "Umut" };

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.ReadLine();


            //string[] students3 = { "Engin", "Mesut", "Umut" };

            //foreach (var student in students3)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.ReadLine();


            //çok boyutlu dizelerde "," kullanılır. 7 satır 3 kolon demek
            // tr de 7 bölge var 3 şehir alıcaz dedik
            //bu şekilde de tanımlayabiliriz.
            string[,] regions = new string[7, 3];

            regions[0, 0] = "İstanbul";
            //.
            //.
            //.

            //diğer yazım şekli
            string[,] regions2 = new string[5, 3]
             {
                 {"İstanbul","İzmit","Balıkesir"},
                 {"Ankara","Konya","Kırıkkale"},
                 {"Antalya","Adana","Mersin"},
                 {"Rize","Trabzon","Samsun"},
                 {"İzmir","Muğla","Manisa"}                

             };

            //GetUpperBound => satırın ve sütunun 1. elemanını almak için kullandık
            //1. forda satırı döndük 2. forda sütun döndük
            //<= kullanmamızın sebebi son değerleride dahil etmek yoksa son elemanları almıyor

            for (int i = 0; i <= regions2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions2.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions2[i, j]);
                }
                Console.WriteLine("***************");
            }

            Console.ReadLine();
        }
    }
}
