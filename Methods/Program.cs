using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20);
            //Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);

            Console.WriteLine(result2);

            //şuan 20 veriyor number1 ancak ref keyword kullanırsak değeri
            //method içindekine dönüşüyor
            //kullanıcıya göre kredi hesaplarken kullanabiliriz mesela

            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //default değerler her zaman methodun sonunda olur 1 adet default değerin var ise.
        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;

        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
