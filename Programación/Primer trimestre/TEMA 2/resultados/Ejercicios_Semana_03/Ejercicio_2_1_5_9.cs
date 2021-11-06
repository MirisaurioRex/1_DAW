
// Ejercicio 2.1.5.9 - Le pedimos al usuario que escriba tres números e indicamos cuál es el mayor

using System;

public class Ejercicio_2_1_5_9
{
	public static void Main()
	{
		int n1, n2, n3;
		
		Console.WriteLine("Dime un número:");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Dime otro número:");
		n2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Dime otro número:");
		n3 = Convert.ToInt32(Console.ReadLine());
		
		// Primer caso: el mayor es el primero
		if (n1 >= n2 && n1 >= n3)
		{
			Console.WriteLine("El mayor es {0}", n1);
		}	
		// Segundo caso: el mayor es el segundo
		else if (n2 >= n1 && n2 >= n3)
		{
			Console.WriteLine("El mayor es {0}", n2);
		}
		// Caso restante: el mayor es el tercero
		else
		{
			Console.WriteLine("El mayor es {0}", n3);
		}	
	}
}
