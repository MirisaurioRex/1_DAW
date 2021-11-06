
/*(2.2.6.5) Dibuja un triángulo de asteriscos descendente. Por ejemplo, si el usuario 
escoge "4" como tamaño, la primera fila tendrá 4 asteriscos, la segunda tendrá 3, 
la siguiente tendrá 2 y la última tendrá 1*/

using System;

public class Ejercicio_2_2_6_5
{
	public static void Main()
	{
		int triangulo;
		
			Console.WriteLine("Decide el tamaño del triángulo");
			triangulo = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 0; i <= triangulo; i ++) {
			for (int j = i+1; j <= triangulo; j++) {
				Console.Write("*");
			}
			Console.WriteLine();
			}
			
	}
}

