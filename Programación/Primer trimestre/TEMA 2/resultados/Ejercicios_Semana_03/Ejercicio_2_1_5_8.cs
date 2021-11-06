
/*
 * Ejercicio 2.1.5.8 - Le pedimos al usuario que escriba dos números y debemos indicar uno de estos casos:
 * - Uno de ellos (pero no los dos) es positivo
 * - Los dos son positivos
 * - Ninguno es positivo
 */ 

using System;

public class Ejercicio_2_1_5_8
{
	public static void Main()
	{
		int n1, n2;
		
		Console.WriteLine("Dime un número:");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Dime otro número:");
		n2 = Convert.ToInt32(Console.ReadLine());
		
		// Primer caso: uno de los dos es positivo pero el otro no. Puede ser el primero o el segundo
		if ((n1 >= 0 && n2 < 0) || (n2 >= 0 && n1 < 0))
		{
			Console.WriteLine("Uno de los dos es positivo");
		}	
		// Segundo caso: los dos son positivos
		else if (n1 >= 0 && n2 >= 0)
		{
			Console.WriteLine("Los dos son positivos");
		}
		// Caso restante: los dos son negativos, o ninguno es positivo
		else
		{
			Console.WriteLine("Ninguno es positivo");
		}	
	}
}
