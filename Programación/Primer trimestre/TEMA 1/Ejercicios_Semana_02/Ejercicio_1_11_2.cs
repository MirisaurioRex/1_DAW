
// Ejercicio 1.11.2 - Modificaci�n del ejercicio 1.9.2 utilizando "using System"

using System;

public class Ejercicio_1_11_2
{
	public static void Main()
	{
		int num1, num2;
		Console.WriteLine("Introduce el primer n�mero");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce el segundo n�mero");
		num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("La divisi�n es {0}", num1/num2);
		Console.WriteLine("El resto es {0}", num1%num2);
	}
}
