
// Ejercicio 2.1.1.1 - Pedirle un número al usuario y decir si es par usando "if"

using System;

public class Ejercicio_2_1_1_1
{
	public static void Main()
	{
		int numero;
		
		Console.WriteLine("Dime un número:");
		numero = Convert.ToInt32(Console.ReadLine());
		
		// Comprobamos si es par
		if (numero % 2 == 0)
		{
			Console.WriteLine("Es par");
		}

		/* El programa no pide que digamos si no es par. Si no, tendríamos que hacer otro "if" para comprobarlo:	
		if (numero % 2 != 0)
		{
			Console.WriteLine("No es par");
		}
		*/
	}
}
