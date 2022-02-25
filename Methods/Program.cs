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
            Add();
            var result = Add2(20);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        
        //default değerler her zaman methodun sonunda olur 1 adet default değerin var ise.
        static int Add2(int number1, int number2=30)
        {
            var result = number1 + number2;
            return result;
           
        }
    }
}
