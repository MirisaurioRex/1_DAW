
// Ejercicio 2.1.8.2 - Usar el operador condicional ?: para detectar el menor de dos numeros

using System;

public class Ejercicio_2_1_8_2
{
	public static void Main()
	{
		int n1, n2, menorNumero;
		
		Console.WriteLine("Dime un número:");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Dime otro número:");
		n2 = Convert.ToInt32(Console.ReadLine());
		
		// Guardamos en la variable menorNumero el menor de los dos, usando el operador ?:
		menorNumero = (n1 < n2)? n1 : n2;
		
		// Sacamos el resultado
		Console.WriteLine("El menor es {0}", menorNumero);
	}
}
