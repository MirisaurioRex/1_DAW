using System;

public class Ejercicio_4_3_3_3
{
	public static void Main ()
	{
		
		string frase;
		int contador = 0;
		
		Console.WriteLine("Escribe una frase");
		frase = Console.ReadLine();
		
		foreach (char letra in frase) {
			if (letra == 'a')
			contador++;
		}
		Console.WriteLine(contador);
			
	} //fin del main
}

