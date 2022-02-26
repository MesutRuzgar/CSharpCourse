using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //strinler aynı zamanda bir char array'dir.
            string city = "Ankara";
            
            //Console.WriteLine(city[0]);
           
            //ankara isminin char itemlerini alt alta yazdırmaya yarıyor.
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            //stringlerin yan yana getirilmesi
            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);

            //bu da farklı bir yan yana yazım şekli
            Console.WriteLine(String.Format("{0} {1}",city,city2));
            Console.ReadLine();
        }
        
    }
}
