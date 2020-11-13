using System;

namespace Ejercicio_1_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 3000;
            int segundoNumero = 1609;
            int calculo; // Guardaré el valor 1609, 1 milla es = a 1609 metros

                      // Dividimos el valor prefijado y el valor de 1 milla en metros para obtener las millas.
            calculo = primerNumero / segundoNumero;

            // Y ya mostraremos por pantalla calcular el valor de las millas 
            System.Console.WriteLine("El valor de {0} metros es igual a {2} en millas", primerNumero, segundoNumero, calculo);

        }
    }
}
