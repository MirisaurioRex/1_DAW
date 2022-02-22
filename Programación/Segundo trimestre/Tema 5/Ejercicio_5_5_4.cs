/*(5.5.4) Crea una función "ContarLetra", que reciba una cadena y una letra, y 
devuelva la cantidad de veces que dicha letra aparece en la cadena. Por ejemplo, si 
la cadena es "Barcelona" y la letra es 'a', debería devolver 2 (porque la "a" aparece 
2 veces).*/

using System;

public class Ejercicio_5_5_4
{
	
	static int ContarLetra (string frase, char letra)
	{
		int contador = 0;
		foreach (char l in frase) 
		{
			if (l == letra)
			{
				contador++;
			}
		}
		
		return contador;
	}
	
	public static void Main()
	{
		string frase;
		char letra;
		
		Console.WriteLine("Escribe una palabra o frase: ");
		frase = Console.ReadLine();
		
		Console.WriteLine("Escribe la letra que deseas buscar: ");
		letra = Convert.ToChar(Console.ReadLine());
		
		Console.WriteLine("La letra {0} aparece {1} veces en la cadena {2}", letra, ContarLetra(frase, letra), frase);
		
	} // fin del Main
}
