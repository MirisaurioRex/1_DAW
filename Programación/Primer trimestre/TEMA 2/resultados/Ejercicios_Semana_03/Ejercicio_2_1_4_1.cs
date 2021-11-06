
// Ejercicio 2.1.4.1 - Mejora del ejercicio 2.1.3.1 usando "else" en lugar de dos "if"

using System;

public class Ejercicio_2_1_4_1
{
	public static void Main()
	{
		int n1, n2;
		
		Console.WriteLine("Dime un número:");
		n1 = Convert.ToInt32(Console.ReadLine());
		
		// Comprobamos si es 0 y sacamos el mensaje correspondiente. En caso contrario (else), pedimos el segundo número y multiplicamos
		if (n1  == 0)
		{
			Console.WriteLine("El producto de 0 por cualquier número es 0");
		}
		else
		{			
			Console.WriteLine("Dime otro número:");
			n2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("{0}x{1} = {2}", n1, n2, n1*n2);
		}
	}
}
