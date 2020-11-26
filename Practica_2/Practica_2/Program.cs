using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------
            // Diego Tristán Pérez Zúñiga
            // Curso DAM
            // Modalidad Presencial
            // Práctica nº 2
            //---------------------------------------

            string palabra;
            int fallos = 6;
            bool correcto = false;
            Console.WriteLine("Introduce la palabra a adivinar.");
            palabra = Console.ReadLine();


            char[] x = new char[palabra.Length];

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = '_';
            }

            // for (int i = 0; i < x.Length; i++)
            // {
            //Console.Write(x[i] + " ");
            // }

            do
            {
                Console.Write("Letra: ");
                char letra = Console.ReadLine().ToCharArray()[0];

                for (int i = 0; i < palabra.Length; i++) 
                {
                    //if the user guessed right, replace the correct dash and display to the user
                    if (palabra[i] == letra)
                    {
                        fallos++; //update the count to check when to exit
                        x[i] = letra;  //here if the user guess correct, we replace the dash with the input

                        //now we display the dash array after it is modified
                        for (int j = 0; j < x.Length; j++)
                        {
                            Console.Write(x[j] + " ");
                        }
                    }
                }
                Console.WriteLine();

                while (fallos >= 0)
                {
                    switch (fallos)
                    {
                        case 6:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│     ");
                                Console.WriteLine("│       ");
                                Console.WriteLine("┴───────");
                                fallos--;
                                break;
                            }

                        case 5:
                            {

                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /    ");
                                Console.WriteLine("│       ");
                                Console.WriteLine("┴───────");
                                fallos--;
                                break;
                            }

                        case 4:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /|   ");
                                Console.WriteLine("│       ");
                                Console.WriteLine("┴───────");
                                fallos--;
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /|\\ ");
                                Console.WriteLine("│       ");
                                Console.WriteLine("┴───────");
                                fallos--;
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /|\\ ");
                                Console.WriteLine("│  /    ");
                                Console.WriteLine("┴───────");
                                fallos--;
                                break;
                            }

                        case 1:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /|\\ ");
                                Console.WriteLine("│  / \\ ");
                                Console.WriteLine("┴───────");
                                Console.WriteLine("R.I.P La palabra era {0}", palabra);
                                fallos--;
                                break;
                            }
                    }

                }


            } while (correcto == true );
        }
    }
}
