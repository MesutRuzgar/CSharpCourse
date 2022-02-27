using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        //ctor tab tab
        //private field _ ile başlar isimlendirme standartıdır.
        int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }

        public  void List()
        {
            Console.WriteLine("Listed! {0} items",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
}
