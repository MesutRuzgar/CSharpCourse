using System;
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
            //2 elemanlı listemiz ancak 3. yi eklemek istediğimizde
            //bellekten hepsi uçacak tekrar newlememiz gerekitiği için
            string[] cities = new string[2] { "ankara", "istanbul" };
            cities = new string[3];
            //0. eleman olarak boş değer verecek nedeni ise üst satırda
            //newlediğimiz için diğer değerler uçtu
            Console.WriteLine(cities[0]);
            Console.ReadLine();
        }
    }
}
