﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        //protected de ise inherit edince gelir property veya method.
        protected int Id { get; set; }
        public void Save()
        {
            //sadece bu block içerisinde geçerli id
            //private olduğu için default olarak
            int id;
        }

    }
    class Student:Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
            //Id;
        }
    }
}
