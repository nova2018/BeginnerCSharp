﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + Math.PI * r * r);
            Console.WriteLine("Perimeter = " + 2 * Math.PI * r);
        }
    }
}