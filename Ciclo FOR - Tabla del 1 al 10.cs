using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 1; x <= 10; x = x + 1)
            {
                Console.WriteLine(" " + x);
            }
            Console.WriteLine("");
            Console.WriteLine("Pulse cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
