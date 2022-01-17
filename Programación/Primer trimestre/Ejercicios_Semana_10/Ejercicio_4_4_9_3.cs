
// Ejercicio 4.4.9.3 - Juego del ahorcado con 8 intentos para adivinar la palabra que escriba el primer usuario

using System;
using System.Text;

public class Ejercicio_4_4_9_3
{
	public static void Main()
	{
		const int MAX_INTENTOS = 8;
		string palabra;
		char letra;
		StringBuilder palabraEnmascarada;
		bool acertada = false;					// Variable booleana para ver si el usuario acierta la palabra
		
		Console.WriteLine("Introduce la palabra a adivinar");
		// Leemos la palabra y la pasamos a minúsculas para no distinguir mayúsculas y minúsculas en el juego
		palabra = Console.ReadLine().ToLower();
		// Construimos el StringBuilder a partir de esa palabra y la llenamos de guiones
		palabraEnmascarada = new StringBuilder(palabra);
		for (int i = 0; i < palabra.Length; i++)
		{
			palabraEnmascarada[i] = '-';
		}
		
		// Bucle para irle pidiendo letras al segundo usuario hasta un máximo de MAX_INTENTOS intentos
		for (int i = 0; i < MAX_INTENTOS && !acertada; i++)
		{
			Console.WriteLine(palabraEnmascarada.ToString());
			Console.WriteLine("Dime una letra:");
			letra = Convert.ToChar(Console.ReadLine().ToLower());
			// Recorremos la palabra enmascarada destapando las letras que coincidan
			for (int j = 0; j < palabraEnmascarada.Length; j++)
			{
				if (letra == palabra[j])
				{
					palabraEnmascarada[j] = letra;
				}
				// Si ya no quedan guiones, hemos acertado la palabra
				if (palabraEnmascarada.ToString() == palabra)
				{
					acertada = true;
					break;
				}
			}
		}
		
		if (acertada)
		{
			Console.WriteLine("Enhorabuena. Has acertado la palabra \"{0}\"", palabra);
		} else {
			Console.WriteLine("Lo siento, has agotado los intentos para acertar la palabra \"{0}\"", palabra);
		}
	}
}
