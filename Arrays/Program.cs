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
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Mesut";
            students[2] = "Umut";


            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();

            string[] students2 = new[] { "Engin", "Mesut", "Umut" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();


            string[] students3 = { "Engin", "Mesut", "Umut" };

            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
    }
}
