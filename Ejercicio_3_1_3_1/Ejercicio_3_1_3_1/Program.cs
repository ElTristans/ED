using System;

namespace Ejercicio_3_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15, y = -10, z = 2147483647;

            Console.WriteLine("x vale {0}", x);
            x++;
            Console.WriteLine("Tras incrementar vale {0}", x);
            x--;
            x--;
            Console.WriteLine("Tras decrementar dos veces, vale {0}", x);

            Console.WriteLine("y vale {0}", y);
            y++;
            y++;
            y++;
            Console.WriteLine("Tras incrementar tres veces, y vale {0}", y);
            y--;
            Console.WriteLine("Tras decrementar vale {0}", y);

            Console.WriteLine("z vale {0}", z);
            z++;
            z++;
            z++;
            z++;
            z++;
            z++;
            Console.WriteLine("Tras incrementar seis veces, z vale {0}", z);
            z--;
            z--;
            z--;
            Console.WriteLine("Tras decrementar tres veces, z vale {0}", z);

        }
    }
}
