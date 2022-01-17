/*  (5.2.2.2) Crea una función llamada "DibujarTriangulo" que dibuje un triángulo de izquierda a derecha y que disminuya
 * una fila cada vez  */

using System;

public class Ejercicio_5_2_2_2
{
	public static void DibujarTriangulo(char c)
	{
		for (int i = 1; i <= 5; i++)
		{
			for (int j = i-1; j < 5; j++)
			{
				Console.Write(c);
			}
			Console.WriteLine();
		}
	}
	
	public static void Main()
	{
		DibujarTriangulo('*');
		
	} // fin del Main
}
