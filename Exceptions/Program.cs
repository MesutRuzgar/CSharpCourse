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

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }

            //method
            //()=> bir method demek karşılığında da bir kod kümesi
            //göndericem demek.

            HandleException(() => {
                Find();
                });
         

            Console.ReadLine();

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
