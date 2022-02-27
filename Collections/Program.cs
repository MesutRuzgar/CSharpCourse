using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            //bir anahtar ile değere ulaşmaya çalışıyoruz
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            //bool verir sonucu. bu anahtar sende varmı diyoruz
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void List()
        {
            //type safe example. sadece string ile çalışıyoruz burada onu belirttik.
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //klasik yöntem
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Mesut" });
            customers.Add(new Customer { Id = 2, FirstName = "Umut" });

            //2. yöntem
            List<Customer> customers2 = new List<Customer>{
            new Customer { Id = 1, FirstName = "Mesut" },
            new Customer { Id = 2, FirstName = "Umut" }
            };


            //farklı ekleme şekli
            var customer3 = new Customer
            {
                Id = 3,
                FirstName = "İdris"
            };
            customers.Add(customer3);

            //veri tabanına örneğin bir liste eklemek istediğimizde
            //bu methodu kullanarak direk ekleyebiliriz.
            //adrange de array veya liste eklenebilir.
            customers.AddRange(new Customer[2]{
                new Customer{Id=4,FirstName="Ali"},
                new Customer{Id=5,FirstName="Ayşe"}
            });

            //bütün listeyi temizler
            // customers.Clear();

            //contains listede var mı? sorusuna eşit. sonuc true yada false döner.
            Console.WriteLine(customers.Contains(customer3));

            //indexlerde aramaya baştan veya sondan dahi başlasa
            //verdiği sonuç baştan başlar ve ona göre sayı üretir
            //sadece arama yeri başı veya sonu olur.
            //listede kaçıncı sırada bize onu verir
            var index = customers.IndexOf(customer3);
            Console.WriteLine("index :{0}", index);

            //burasıda aramaya sondan başlar
            var index2 = customers.LastIndexOf(customer3);
            Console.WriteLine("index :{0}", index2);

            //add methodu gibi işler ancak aradaki farkı
            //insertte verdiğimiz int değer listede nereye ekliyeceğimizi
            //gösterir. yani listenin başına veya sonuna bu şekilde veri ekleyebiliriz.
            customers.Insert(0, customer3);

            //remove değeri birden fazla değer olsa bile bulduğu
            //ilk değeri siler ve methodu durdurur.
            //customers.Remove(customer3);

            //listede ismi mesut olanların tamamı siler
            // customers.RemoveAll(c=>c.FirstName=="Mesut");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            //eleman sayısını verir count
            var count = customers.Count;
            Console.WriteLine("Count :{0}", count);
        }

        private static void ArrayList()
        {
            //eğer çalıştığımız nesnede type safe yoksa yani belirli bir 
            //type yoksa arraylist tercih edilebilir. Belli bir sınır yoktur
            //istediğimiz kadar ekleyebiliriz.
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('a');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
