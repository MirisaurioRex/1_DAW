
// Ejercicio 2.1.5.1 - Le pedimos al usuario un número y le indicamos si es múltiplo de 2 o de 3 (de cualquiera de ellos, sin importar cuál)

using System;

public class Ejercicio_2_1_5_1
{
	public static void Main()
	{
		int numero;
		
		Console.WriteLine("Dime un número:");
		numero = Convert.ToInt32(Console.ReadLine());
		
		// Comprobamos si es múltiplo de 2 o de 3 y sacamos el mensaje correspondiente
		if ((numero % 2 == 0) || (numero % 3 == 0))
		{
			Console.WriteLine("Es múltiplo de 2 o de 3");
		}		
	}
}
