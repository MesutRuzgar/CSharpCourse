using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //değer tiplerde 1 kere atama yapılınca daha sonradan
            //değeri değiştirmek istesende sonuç bir öncesinde atadığın
            //sayı olur
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            //referans tiplerde atama yapıldıktan sonra bellekte diğerinin bir 
            //karşılığı kalmaz ve bellekten o değerler uçurulur.

            string[] cities = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities;
            cities[0] = "İstanbul";

            Console.WriteLine(cities2[0]);

            Console.ReadLine();

        }
    }
}
