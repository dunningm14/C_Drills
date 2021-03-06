/*************************************************************************************************************************
Author: Madison Dunning
Date: 11/29/16
OS: Windows 10
Purpose: Demonstrate the use of an interface   
         
**************************************************************************************************************************/﻿

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

nnamespace InterfaceApplication
{
    interface sayHello
    {
        string printHello();
    }
    class Hello : IHello
    {
        public string printHello()
        {
            Console.WriteLine("Hello!");
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hello hi = new Hello();
            hi.printHello();
        }
    }
}
