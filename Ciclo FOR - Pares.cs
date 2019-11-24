using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nethend
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 2; x <= 10; x = x + 2)
            {
                Console.WriteLine(" " + x);
            }
            Console.WriteLine("");
            Console.WriteLine("Pulse cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
