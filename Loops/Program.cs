using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //ForLoop2();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number!");
            }
            else
            {
                Console.WriteLine("This is not a prime number!");
            }
            Console.ReadLine();

        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            //2 asal sayı olduğunu için i yi 2 den başlattık
            //sonuç 0 olursa result false dönecek
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    //i=number dememizin sebebi sonuçu 0 yakaladığı anda algoritmanın
                    //durmasını sağlamak. Yoksa verdiğimiz ramana ulaşana kadar tekrar edecektir.
                    i = number;
                }
            }
            return result;
        }

        private static void ForeachLoop()
        {
            string[] students = { "Engin", "Mesut", "Umut" };
            foreach (var student in students)
            {

                Console.WriteLine(student);
            }
            Console.ReadLine();
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

                //çok kullanılmayan bir yöntem
                //While koşulu sağlanmasa bile kod 1 kez çalışır
                //örnek olarak data yoksa sayfayı kapat olabilir

            } while (number >= 11);
            Console.ReadLine();
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(100);
                //whilede koda bu şekilde müdahale etmez isek kod sonsuza kadar çalışır.
                number--;

            }
        }     

        private static void ForLoop()
        {
            //i 1 den başlıcak; 100 e kadar ve 100 dahil;
            //i++ her döngü bittiğinde 1 arttıracak demek;
            //i=i+2 de yazabiliriz 2 arttır demek
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        private static void ForLoop2()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                //burası da tersten yazım şekli 100 den başlayıp 2 azaltıyor 0 olunca bitiyor.
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
