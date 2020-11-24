using System;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------
            // Diego Tristán Pérez Zúñiga
            // Curso DAM
            // Modalidad Presencial
            // Práctica nº 1
            //---------------------------------------

            int contador = 0;
            int numero1=0;
            int resultado=0;
            char operador;


            Console.WriteLine("Introduce un número:");
            contador = Convert.ToInt32(Console.ReadLine());
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Introduce un operador:");
                        operador = Convert.ToChar(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("--> Operación incorrecta");
                    }
                }
                while (true);


                if ((operador != '=') && (operador != 's'))
                {

                    do
                    {
                        try
                        {
                            Console.WriteLine("Introduce un número:");
                            numero1 = Convert.ToInt32(Console.ReadLine());

                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("--> Número incorrecto");
                        }
                    }
                    while (true);
                }
              
                switch (operador)
                    {
                        case '+':
                            resultado = resultado + (contador + numero1);
                            break;

                        case '-':
                            resultado = resultado + (contador - numero1);
                            break;

                        case '*':
                            resultado = resultado + (contador * numero1);
                            break;

                        case '/':
                            resultado = resultado + (contador / numero1);
                            break;

                        case '=':
                            Console.WriteLine("El resultado es {0}", resultado);
                   
                            break;

                }

            } while (operador != 's'); 
            Console.WriteLine("FIN DEL PROGRAMA");
        }
    }
}
