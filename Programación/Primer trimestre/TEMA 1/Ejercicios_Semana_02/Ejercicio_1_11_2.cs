
// Ejercicio 1.11.2 - Modificación del ejercicio 1.9.2 utilizando "using System"

using System;

public class Ejercicio_1_11_2
{
	public static void Main()
	{
		int num1, num2;
		Console.WriteLine("Introduce el primer número");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce el segundo número");
		num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("La división es {0}", num1/num2);
		Console.WriteLine("El resto es {0}", num1%num2);
	}
}
