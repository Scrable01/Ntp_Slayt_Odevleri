using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int x = 5, y = 10;
            x += 2;
            const int z = x + y;
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
