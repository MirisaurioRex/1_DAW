/*  (5.3.2) Crea una función "DibujarRectangulo" que dibuje en pantalla un rectángulo 
del ancho y alto que se indiquen como parámetros, en ese orden. Incluye un Main 
para probarla. */

using System;

public class Ejercicio_5_3_2
{
	public static void DibujarRectangulo(char c)
	{
		for (int i = 1; i <= 3; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				Console.Write(c);
			}
			Console.WriteLine();
		}
	}
	
	public static void Main()
	{
		DibujarRectangulo('*');
		
	} // fin del Main
}
