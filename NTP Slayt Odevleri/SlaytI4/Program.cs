﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlaytI4
{
    interface IArayuz
    {
        int Metot1();
        void Metot2();
        int Sayi
        {
            get;
            set;
        }
        int this[int indeks] { get; }
    }
    class Sinif : IArayuz
    {
        private int sayi;
        public int Metot1()
        {
            Console.WriteLine("Metot1");
            return 0;
        }
        public void Metot2() {
            Console.WriteLine("Metot2");
        }
        public int Sayi
        {
            get{ return sayi; }
            set{ sayi=value;}
        }
        public int this[int indeks]
        {
            get { return indeks; }
            set { }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif s = new Sinif();
            IArayuz a;
            a = s;
            a.Metot1();
            Console.Read();
        }
    }
}
