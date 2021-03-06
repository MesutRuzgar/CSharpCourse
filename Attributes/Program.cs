using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {
                Id = 1, LastName = "Rüzgar", Age = 20 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    [ToTable("Customers")]
       
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class CustomerDal
    {
        //obsolete hazır bir attributedir
        //yeni bir method yazdığımızda eski kod yerine yenisini kullanmaya
        //yöneltmek için kullanılıyor.
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName,
                customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName,
                customer.LastName, customer.Age);
        }
    }
    //bir attribute'ın üzerine attributeusage eklenirse onu nasıl kullanacağımız şekillenir.
    //targets ise nerede kullanacağımızı belirtir. .All dersek heryerde kullanılır.
    //.Class dersek sadece classlarda kullanabiliriz
    // pipe kullanarak multi kullanıma açmış oluyoruz. istediğimiz kadar | koyarak ekleriz
    //allow multiple true olursa aynı yerde 2 kere kullanmamıza yarar

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    
    class RequiredPropertyAttribute:Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute:Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

}
