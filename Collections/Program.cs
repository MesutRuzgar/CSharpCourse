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
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }


            Console.ReadLine();
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
