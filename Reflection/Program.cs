using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //klasik yöntem
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla(3, 4));

            ////ctor dan gelen değerlerle çalışıyor
            //Console.WriteLine(dortIslem.Topla2());


            //reflection kullanımı
            var tip = typeof(DortIslem);

            //bu kod 14. satırdaki işlemle aynı değer newlemeye yarıyor.
            //create instance obje döndürür hata vermemesi için başına tipini ekledik () içinde
            //parametresiz
            //DortIslem dortIslem =(DortIslem)Activator.CreateInstance(tip);
            //Console.WriteLine(dortIslem.Topla(4, 5));


            //parametreli version
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(tip, 6, 7);
            //gettype tipini bulur getmethod ile methodu çağırır
            //invoke ile calıştırır parantez içerisinde parametre varsa ekleriz
            //tekrar içine instance yazmamızın sebebi methodu bulduk ama neyi 
            //çalıştırıcağınıda belirtmiş olduk 
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null)); 

            Console.ReadLine();

        }
    }

   public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        //parametresiz
        public DortIslem()
        {

        }

        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;

        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;

        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;

        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;

        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;

        }
    }
}
