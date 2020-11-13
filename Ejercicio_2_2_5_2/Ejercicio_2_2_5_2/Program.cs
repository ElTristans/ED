using System;

namespace Ejercicio_2_2_5_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int tabla, numero;
			for (tabla = 1; tabla <= 5; tabla++)
			{
				for (numero = 1; numero <= 10; numero++)
					Console.WriteLine("{0} por {1} es {2}", tabla, numero,
					tabla * numero);
				Console.WriteLine();
			}
		}
	}
}
