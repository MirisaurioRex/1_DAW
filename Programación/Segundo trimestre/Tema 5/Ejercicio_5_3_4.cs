/*  (5.3.5) Crea una nueva versión de la función "DibujarRectangulo", que se apoye en 
la "EscribirRepetido" que acabas de crear.*/

using System;

public class Ejercicio_5_3_5
{
	
	public static void EscribirRepetido( char c)
	{
		int numero = 5;
		for (int i = 0; i < numero; i++)
		{
			Console.Write(c);
		}
	}
	
	public static void DibujarRectangulo(char v)
	{
		int n = 3;
		for (int i = 0; i < n; i++)
		{
			EscribirRepetido(v);
			Console.WriteLine();
		}
	}
	
	public static void Main()
	{
		DibujarRectangulo('*');
	} // fin del Main
}
