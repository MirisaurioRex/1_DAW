
// Ejercicio 2.1.5.4 - Le pedimos al usuario un número y le indicamos si no es múltiplo de 2 ni de 3

using System;

public class Ejercicio_2_1_5_4
{
	public static void Main()
	{
		int numero;
		
		Console.WriteLine("Dime un número:");
		numero = Convert.ToInt32(Console.ReadLine());
		
		// Comprobamos si no es múltiplo de 2 ni de 3 y sacamos el mensaje correspondiente
		if ((numero % 2 != 0) && (numero % 3 != 0))
		{
			Console.WriteLine("No es múltiplo de 2 ni de 3");
		}		
	}
}
