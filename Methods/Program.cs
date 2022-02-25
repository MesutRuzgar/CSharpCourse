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

            int number1 ;
            int number2 = 100;

            //ref keyword de yukarıda değer set etmek zorundayız ancak
            //out keyword de yukarıda herhangi bir değer set etmek zorunda değiliz
            var result2 = Add3(out number1, number2);

            //Console.WriteLine(result2);

            //şuan 20 veriyor number1 ancak ref keyword kullanırsak değeri
            //method içindekine dönüşüyor
            //kullanıcıya göre kredi hesaplarken kullanabiliriz mesela

            //Console.WriteLine(number1);

            //Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
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

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        //method aynı isimde olsa bile parametresi farklı olduğundan sorun çıkmaz
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2* number3;
        }

        //birden fazla parametre varsa bu şekilde sürekli overload yapmaktansa yazabiliriz.
        //params parametresi birden fazla parametre var ise en sonda olmak zorunda
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
      
    }
}
