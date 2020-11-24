using System;

namespace Ejercicio_4_4_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            string operador;
            int resultado;

            Console.WriteLine("Introduce un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el operador: ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "suma":
                case "+":
                    resultado = numero1 + numero2;
                    Console.WriteLine("La suma de {0} y {1} es {2}",numero1,numero2,resultado);
                break;

                case "resta":
                case "-":
                    resultado = numero1 - numero2;
                    Console.WriteLine("La resta de {0} y {1} es {2}", numero1, numero2, resultado);
                break;

                case "multiplicacion":
                case "*":
                case "x":
                case "X":
                    resultado = numero1 * numero2;
                    Console.WriteLine("La multiplicacion de {0} y {1} es {2}", numero1, numero2, resultado);
                break;

                case "division":
                case "/":
                    resultado = numero1 / numero2;
                    Console.WriteLine("La division de {0} y {1} es {2}", numero1, numero2, resultado);
                break;
            }
        }
    }
}
