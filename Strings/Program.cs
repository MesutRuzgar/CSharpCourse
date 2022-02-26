using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro();

            string sentence = "My name is Mesut Rüzgar";

            //cümlenin toplam karakter sayısı
            var result = sentence.Length;
            Console.WriteLine(result);

            //cümleyi klonlamaya yarar
            //klonladıktan sonra altında değiştirsek bile 
            //referansını klonladığımız için result2 değişmiyor
            var result2 = sentence.Clone();
            sentence = "My name is Umut Rüzgar";
            Console.WriteLine(result2);

            //cümle "ğ" ile bitiyor mu veya "my name" ile başlıyor mu ?
            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            //belli bir karakteri yada ifadeyi aramaya yarar
            //kaçıncı karakterden başladığını verir sonuç olarak            
            //bulamazsa -1 verir sonucu
            var result5 = sentence.IndexOf("name");
            Console.WriteLine(result5);

            //bulduğu ilk boşluğu verir daha sonra devam etmez aramaya
            var result6 = sentence.IndexOf(" ");

            //bu kod ise sondan başlar aramaya 
            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result7);

            //bu kod cümleye bir şey eklemeye yarar
            //0. dan itibaren "Hello, " ekledi cümleye
            var result8 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result8);

            //bu kod string veriyi parçalamaya yarıyor
            //3. karakterden itibaren yazdır dedik.
            var result9 = sentence.Substring(3);
            Console.WriteLine(result9);

            //3. karakterden sonra 4 karakter al demek
            var result10 = sentence.Substring(3,4);
            Console.WriteLine(result10);

            //bütün karakterleri küçük yapar
            var result11 = sentence.ToLower();
            Console.WriteLine(result11);

            //bütün karakterleri büyük yapar
            var result12 = sentence.ToUpper();
            Console.WriteLine(result12);

            //bu kodda boşluk yerine "-" kullan dedik ve boşlukları kaldırıp - koyduk.
            var result13 = sentence.Replace(" ", "-");
            Console.WriteLine(result13);

            //belli bir indexten sonrasını atmaya yarıyor
            //2 den itibaren sil dedik
            var result14 = sentence.Remove(2);
            Console.WriteLine(result14);

            //2 den itibaren 5 karakter sil dedik
            var result15 = sentence.Remove(2,5);
            Console.WriteLine(result15);
            Console.ReadLine();
        }

        private static void Intro()
        {
            //strinler aynı zamanda bir char array'dir.
            string city = "Ankara";

            //Console.WriteLine(city[0]);

            //ankara isminin char itemlerini alt alta yazdırmaya yarıyor.
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            //stringlerin yan yana getirilmesi
            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);

            //bu da farklı bir yan yana yazım şekli
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
