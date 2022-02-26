using System;


namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //IsNewInterface();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());

            Console.ReadLine();

        }

        private static void IsNewInterface()
        {
            //intefaceler new lenemez ancak ona bağlı claslar newlenebilir.
            IPerson person = new Customer();
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Mesut", LastName = "Rüzgaar", Adress = "İstanbul" });
            Console.ReadLine();
        }

        //soyut nesne
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }

        //somut nesne
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Adress { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
