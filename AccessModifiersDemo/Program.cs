using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //accessmodifers da gidip public yaptık ve erişim tamamlandı
            //public yapmazsak referans versek dahi görmez kod.
            Course coruse = new Course();
        }
    }
}
