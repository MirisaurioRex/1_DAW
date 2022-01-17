
// Ejercicio 4.4.2.1 - Programa que le pide al usuario su nombre y le dice cuál es su inicial

using System;

public class Ejercicio_4_4_2_1
{
	public static void Main()
	{
		string nombre;
		
		Console.WriteLine("Dime tu nombre:");
		nombre = Console.ReadLine();
		
		Console.WriteLine("Tu inicial es {0}", nombre[0]);		
	}
}
