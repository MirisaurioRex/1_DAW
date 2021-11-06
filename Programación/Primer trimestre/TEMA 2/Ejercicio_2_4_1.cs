
/*(2.4.1) Crea un programa que cuente cuantas veces aparece la letra 'a' en una 
frase que teclee el usuario, utilizando "foreach".*/

using System;

public class Ejercicio_2_4_1
{
	public static void Main()
	{
		string frase;
		int contador = 0;
		
			Console.WriteLine("Escribe una frase");
			frase = Console.ReadLine();
		
		foreach(char letra in frase) {
			if (letra == 'a')
			contador++;
			}
				Console.WriteLine("En la frase aparecen {0} aes", contador);
			
	}
}

