using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            {
                //  DECLARACION DE VARIABLES DEL MENU
                string ClaveIngreso, NombreIngreso, RespuestaContinuar;
                int OpcionMENU = 0;
                Console.WriteLine();
                Console.WriteLine("INGRESE SU NOMBRE");
                NombreIngreso = Console.ReadLine();

                do
                {
                    // Sitema de "Login" para poder acceder al contenido
                    Console.WriteLine();
                    Console.WriteLine("Hola " + NombreIngreso + " Ingrese la clave para ver el contenido");
                    Console.WriteLine();
                    ClaveIngreso = Console.ReadLine();
                } while (ClaveIngreso != "301303");



                {
                    // Se da la bienvenida al usuario y que opcion va a escoger
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Hola, Bienvenido " + NombreIngreso + " Seleccione que programa va usar:");
                    Console.WriteLine();


                    do
                    {
                        // Opciones del MENU

                        Console.Write("Menu de Opciones: \n" +
                                    "1.- Juego de dados \n" +
                                    "2.- Cajero electrónico \n" +
                                    "3.- Costo Metro Cuadrado \n" +
                                    "4.- Juego Libre \n" +
                                    "5.- SALIR \n");
                        OpcionMENU = Convert.ToInt32(Console.ReadLine());


                        switch (OpcionMENU)
                        {
                            case 1:
                                Console.WriteLine("Ejercicio 1 ");
                                {

                                    {
                                        //Desarrollo del ejercicio...

                                    }

                                    {

                                        do
                                        {
                                            // COMANDO para regresar al MENU
                                            Console.WriteLine("¿Desea continuar usando el programa y volver al menu? SI/NO)");
                                            RespuestaContinuar = Console.ReadLine();
                                        } while (RespuestaContinuar != "SI");
                                        Console.Clear();

                                        //COMO HAGO PARA QUE EL USUARIO EN CASO DE SELECCIONAR LA OPCION DE "NO"
                                        //EL PROGRAMA SE CIERRE...

                                    }


                                }
                                break;
                            case 2:
                                Console.WriteLine("Ejercicio 2 ");
                                break;
                            case 3:
                                Console.WriteLine("Ejercicio 3 ");
                                break;
                            case 4:
                                Console.WriteLine("Ejercicio 4 ");
                                break;
                            case 5:
                                Console.WriteLine("Salir: Estas saliendo de la Aplicacion");
                                break;
                            default:
                                Console.WriteLine("Ingrese una OPCION VALIDA");
                                break;

                        }


                    } while (OpcionMENU == 5);
                }

                Console.ReadKey();
            }
        }
    }
}

