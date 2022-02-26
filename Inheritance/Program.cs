using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Student{FirstName="Mesut" },
                new Customer{FirstName="Umut" },
                new Person{FirstName="İdris" }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
            
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        interface Person2
        {
            //altta klasa 1 kere inherit alabiliriz anca 2. clası inherit edemeyiz
            //interfacede bu durum yoktur.
            //inherit önce yazılır sonra interfaceler yazılır.
        }

        class Customer:Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Departmant { get; set; }
        }
    }
}
