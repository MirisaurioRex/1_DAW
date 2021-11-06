
// Ejercicio 2.1.3.1 - Multiplicación de dos números si el primero no es cero (si es cero, avisar de que el resultado será cero)

using System;

public class Ejercicio_2_1_3_1
{
	public static void Main()
	{
		int n1, n2;
		
		Console.WriteLine("Dime un número:");
		n1 = Convert.ToInt32(Console.ReadLine());
		
		// Comprobamos si es 0 y sacamos el mensaje correspondiente
		if (n1  == 0)
		{
			Console.WriteLine("El producto de 0 por cualquier número es 0");
		}
		
		// Comprobamos si no es 0, pedimos el segundo número y realizamos la multiplicación
		if (n1 != 0)
		{			
			Console.WriteLine("Dime otro número:");
			n2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("{0}x{1} = {2}", n1, n2, n1*n2);
		}
	}
}
