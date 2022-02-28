using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //parametresiz delegate
    public delegate void MyDelegate();
    //parametreli delegate
    public delegate void MyDelegate2(string text);
    //parametreli ve void olmayan delegate
    public delegate int MyDelegate3(int number1,int number2);

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();

            Console.WriteLine("---------------------------");

            //delegate kullanımı
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            //send messageyi sildik selam verme direk uyar dedik
            myDelegate -= customerManager.SendMessage;

            myDelegate();

            Console.WriteLine("--parametreli--");
            //parametreli delagete
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            
            myDelegate2("Hello");

            //int delegate örnek mat class oluşturduk
            Matematik matematik = new Matematik();

            //delegelerde int gibi bir return varsa en son yazdığımız kodu
            //ekrana yazar void türündeki gibi birleştirme
            //alttaki örnekte toplama sonucu uçar sadece çarpma sonucunu basar
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc =myDelegate3(2,3);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        //parametreli delegate için
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
}
