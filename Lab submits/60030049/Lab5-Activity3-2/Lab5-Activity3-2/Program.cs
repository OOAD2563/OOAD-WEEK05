﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Activity3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.print();
            ((Parent)child).print();
        }

        public class Parent
        {
            string parentString;
            public Parent()
            {
                Console.WriteLine("Parent Constructor.");
            }
            public Parent(string myString)
            {
                parentString = myString;
                Console.WriteLine(parentString);
            }
            public void print()
            {
                Console.WriteLine("I'm a Parent Class.");
            }
        }

        public class Child : Parent
        {
            public Child():base("From Derived")
            {
                Console.WriteLine("Child Constructor");
            }
            public new void print()
            {
                base.print();
                Console.WriteLine("I'm a Child Class.");
            }
        }
    }
}
