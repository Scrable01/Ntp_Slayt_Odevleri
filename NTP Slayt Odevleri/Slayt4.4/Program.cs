﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "ali", "ahmet", "selda", "canan", "melike" };
            Console.WriteLine("aranan isim=");
            string aranan = Console.ReadLine();
            foreach (string ss  in isimler)
            {
                if (aranan.Equals(isimler[0]))
                    Console.WriteLine("aranan isim bulundu...");
                else Console.WriteLine("isim yok");
            }
            Console.ReadKey();
        }
    }
}
