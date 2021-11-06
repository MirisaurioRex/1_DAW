
// Ejercicio 2.1.1.2 - Pedirle dos números al usuario y ver cuál es el mayor de ellos

using System;

public class Ejercicio_2_1_1_2
{
	public static void Main()
	{
		int n1, n2;
		
		Console.WriteLine("Dime un número:");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Dime otro número:");
		n2 = Convert.ToInt32(Console.ReadLine());
		
		// Primer caso: que el mayor sea el primero
		if (n1 > n2)
		{
			Console.WriteLine("El mayor es {0}", n1);
		}
		
		// Segundo caso: que el mayor sea el segundo
		if (n2 > n1)
		{
			Console.WriteLine("El mayor es {0}", n2);
		}

		/* El programa no saca nada si los dos datos son iguales. Aún no hemos visto a esta altura del tema cómo comprobar si dos datos son iguales, así que de momento no lo comprobaremos */
	}
}
