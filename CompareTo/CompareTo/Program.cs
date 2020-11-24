using System;

namespace CompareTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "";
            string cadena2 = "";

            Console.Write("Cadena 1;");
            cadena1 = Console.ReadLine();

            Console.Write("Cadena 1;");
            cadena2 = Console.ReadLine();

            if (cadena1.CompareTo(cadena2)>0)
            {
                Console.WriteLine("La cadena 1 es mayor que la cadena 2");
            }
            else 
            { 
               if (cadena1.CompareTo(cadena2)>0)
                {
                    Console.WriteLine("La cadena 2 es mayro que la cadena 1");
                }
               else
                {
                    Console.WriteLine("Son iguales");
                }
               // funciona mediante los valores ascii

            }
        }
    }
}
