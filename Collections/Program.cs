using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //eğer çalıştığımız nesnede type safe yoksa yani belirli bir 
            //type yoksa arraylist tercih edilebilir. Belli bir sınır yoktur
            //istediğimiz kadar ekleyebiliriz.
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

           
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('a');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            Console.ReadLine();
        }
    }
}
