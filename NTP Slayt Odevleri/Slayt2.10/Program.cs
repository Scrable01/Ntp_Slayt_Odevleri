﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object o = i;
            long l = (long)o;
            Console.WriteLine(l);
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
