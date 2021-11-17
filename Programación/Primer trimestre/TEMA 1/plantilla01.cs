/*  (3.3.1.1) Crea un programa que pida una letra al usuario y diga si se trata de una 
vocal.   */

using System;

public class Ejercicio_3_3_1_1
{
	public static void Main()
	{
		char letra;
		
		Console.WriteLine("Escribe una letra");
		letra = Convert.ToChar(Console.ReadLine());
		
		if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
			Console.WriteLine("La letra es una vocal");
		else
			Console.WriteLine("La letra no es una vocal");
		
	}
}
