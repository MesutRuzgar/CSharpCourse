using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            Console.ReadLine();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Console.ReadLine();

            //klasik yöntem
            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            //daha efektif kullanım
            Customer customer1 = new Customer {Id=2,FirstName="Mesut",LastName="Rüzgar",
            City="İstanbul"};

            Console.WriteLine(customer1.FirstName);
            Console.ReadLine();
        }
        
    }

   
   
}
