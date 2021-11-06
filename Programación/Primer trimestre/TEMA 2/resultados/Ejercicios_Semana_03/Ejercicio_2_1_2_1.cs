
// Ejercicio 2.1.2.1 - Pedirle al usuario un número. Si es múltiplo de 10, pedirle un segundo número y comprobar si también es múltiplo de 10

using System;

public class Ejercicio_2_1_2_1
{
	public static void Main()
	{
		int n1, n2;
		
		Console.WriteLine("Dime un número:");
		n1 = Convert.ToInt32(Console.ReadLine());
		if (n1 % 10 == 0)
		{
				// Informamos de que es múltiplo de 10 y pedimos el segundo número
				Console.WriteLine("Es múltiplo de 10");
				Console.WriteLine("Dime otro número:");
				n2 = Convert.ToInt32(Console.ReadLine());
				if (n2 % 10 == 0)
				{
					// Informamos de que también es múltiplo de 10
					Console.WriteLine("También es múltiplo de 10");
				}
		}
	}
}
