using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int veri tipinin alabileceği max ve min rakamlar
            //32 byte yer kaplar

            int number1 = -2147483648;
            int number2 = 2147483647;

            //long veri tipi int veri tipini içinde barındırır.
            //long sınırı ise 19 karakterden oluşur
            //64 byte yer kaplar
            //long veri tipinin alabileceği max ve min rakamlar

            long number3 = -9223372036854775808;
            long number4 = 9223372036854775807;

            //short veri tipi 16 byte yer kaplar
            //short veri tipinin alabileceği max ve min rakamlar

            short number5 = -32768;
            short number6 = 32767;

            //byte veri tipi 8 byte yer kaplar
            //byte veri tipinin alabileceği max ve min rakamlar

            byte number7 = 0;
            byte number8 = 255;

            //boolean veri tipi mantıksal veri tipidir
            //değer tiptir

            bool condition = true;

            //char veri tipi değer tiptir

            char character = 'A';

            //double veri tipi tam sayı tanımlayabiliriz sadece ondalıklı olmayabilir.
            //ancak ondalıklı sayıyı int içerisinde tanımlayamayız.
            //64 byte yer tutar

            double number9 = 10.4;

            //decimal veri tipi doubleye göre daha fazla karakter tutar
            //doubleye göre daha hassas işler için kullanılır
            //örneğin para tutarı.
            //aradaki farkı ise ondalıklı sayı yazınca sonuna "m" veya "M" eklemek gerekiyor.
            //ondalıkli değil ise atadığın değer "m" yazmak zorunlu değil.

            decimal number10 = 10.4m;

            //Enum veri tipi de değer tiptir.
            //magic string yapmış oluyoruz her yeri değiştirmemek için

            //if (Days.Friday==...)
            //{

            //}

            //başına (int) yazınca yazdırdığımız değerin sayısal karşılığını bize verir
            //enumda istersek o sayısal değerleri değiştirebiliriz bunu unutma.

            Console.WriteLine("Number1 is {0}", number10);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();



        }

        enum Days
        {
            Monday=10,TuesDay=20,Wednesday,Thursday,Friday,Saturday,Sunday
        }
    }
}
