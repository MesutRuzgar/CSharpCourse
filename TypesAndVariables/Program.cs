﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int veri tipinin alabileceği max ve min rakamlar
            //32 byte yer kaplar

            int number1 = -2147483648;
            int number2 = 2147483647;

            //long veri tipi int veri tipini içinde barındırır.
            //long sınırı ise 19 karakterden oluşur
            //64 byte yer kaplar
            //long veri tipinin alabileceği max ve min rakamlar

            long number3 = -9223372036854775808;
            long number4 = 9223372036854775807;

            //short veri tipi 16 byte yer kaplar
            //short veri tipinin alabileceği max ve min rakamlar

            short number5 = -32768;
            short number6 = 32767;

            Console.WriteLine("Number1 is {0}",number4);
            Console.ReadLine();



        }
    }
}