
// Ejercicio 4.4.3.1 - Programa que le pide al usuario su nombre y separa cada letra con un espacio

using System;

public class Ejercicio_4_4_3_1
{
	public static void Main()
	{
		string nombre;
		
		Console.WriteLine("Dime tu nombre:");
		nombre = Console.ReadLine();
		
		for (int i = 0; i < nombre.Length; i++)
		{		
			Console.Write("{0} ", nombre[i]);		
		}
		Console.WriteLine();
	}
}
