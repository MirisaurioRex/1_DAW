
// Ejercicio 4.4.4.2 - Programa que le pide al usuario su nombre y muestra una triángulo creciente añadiendo cada vez una letra del mismo

using System;

public class Ejercicio_4_4_4_2
{
	public static void Main()
	{
		string nombre;
		
		Console.WriteLine("Dime tu nombre:");
		nombre = Console.ReadLine();
		
		for (int i = 0; i < nombre.Length; i++)
		{
			Console.WriteLine("{0}", nombre.Substring(0, i+1));
		}
	}
}
