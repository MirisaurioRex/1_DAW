
// Ejercicio 4.4.8.2 - Programa que le pide al usuario cinco frases y le dice cuál es la mayor de todas

using System;

public class Ejercicio_4_4_8_2
{
	public static void Main()
	{
		const int MAX_FRASES = 5;
		string[] frases = new string[MAX_FRASES];
		string mayor;
		
		Console.WriteLine("Dime {0} frases:", MAX_FRASES);
		for (int i = 0; i < MAX_FRASES; i++)
		{
			frases[i] = Console.ReadLine();
		}
		
		// Vemos cuál es la mayor. Al principio suponemos que es la primera, y vamos comparando las demás
		mayor = frases[0];
		for (int i = 1; i < MAX_FRASES; i++)
		{
			if (frases[i].CompareTo(mayor) > 0)
			{
				mayor = frases[i];
			}
		}
		Console.WriteLine("La mayor es {0}", mayor);
	}
}
