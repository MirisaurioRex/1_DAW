
// Ejercicio 4.4.5.1 - Programa que le pide al usuario 10 cadenas de texto, las guarda en un array, y luego busca en ellas los textos que le diga el usuario, hasta que escriba fin

using System;

public class Ejercicio_4_4_5_1
{
	public static void Main()
	{
		const int MAX_FRASES = 10;
		string[] frases = new string[MAX_FRASES];
		string buscar;
		bool encontrado;
		
		Console.WriteLine("Dime {0} frases:", MAX_FRASES);		
		for (int i = 0; i < frases.Length; i++)
		{		
			frases[i] = Console.ReadLine();
		}
		
		// Vamos buscando textos hasta que el usuario escriba "fin"
		do
		{
			Console.WriteLine("Dime un texto a buscar. Escribe \"fin\" para terminar:");
			buscar = Console.ReadLine();
			encontrado = false;				
			// Nos guardaremos en cada pasada si hemos encontrado el texto a buscar en al menos alguna frase
			for (int i = 0; i < frases.Length; i++)
			{
				if (frases[i].Contains(buscar))
				{
					Console.WriteLine("Aparece en la frase {0}: {1}", i+1, frases[i]);
					encontrado = true;
				}
			}
			if (!encontrado)
			{
				Console.WriteLine("El texto no aparece en ninguna de las frases");
			}
		} while (buscar != "fin");
	}
}
