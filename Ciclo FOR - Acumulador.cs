using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strength
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, s = 0, o = -1;
            for (x = 1; x <= 10; x = x + 1)
            {
                Console.WriteLine(" " + x);
                s = s + x + o;
            }
           
            Console.WriteLine("Acumulador: " + s);
            Console.WriteLine("");
            Console.WriteLine("Pulse cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
