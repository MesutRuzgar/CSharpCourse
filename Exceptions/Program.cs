using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //TryCatch();

            //ActionDemo();

            //1 ve 2. si parametreler 3.sü dönüş tipi
            Func<int, int, int> add = Topla;
            //Console.WriteLine(add(3,5));

            //parametresiz methodu int olarak döndürüyor demek
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            //farklı bir yazım şekli action gibi
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();

        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            //method
            //()=> bir method demek karşılığında da bir kod kümesi
            //göndericem demek.

            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        //action parametresiz method bir voiddir return dönmez
        private static void HandleException(Action action)
        {
            try
            {
                //ınvoke demek methodu çalıştır demek
                action.Invoke();

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Mesut", "Umut", "İdris" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException ("Record not found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            };
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Mesut", "Umut", "İdris" };
                //hata verir burası
                students[3] = "Mehmet";

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
