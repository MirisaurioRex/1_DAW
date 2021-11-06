
/*(2.2.6.3) Haz un programa que dibuje un cuadrado de asteriscos, cuyo ancho (y 
alto, que tendrá el mismo valor) será introducido por el usuario.*/

using System;

public class Ejercicio_2_2_6_3
{
	public static void Main()
	{
		int fila, columna;
		int ancho;
		int alto;
		
			Console.WriteLine("Decide de cuánto será el lado del cuadrado");
			ancho = Convert.ToInt32(Console.ReadLine());
			alto = ancho;
		
		for (fila = 1; fila <= ancho; fila++) {
			for (columna = 1; columna <= alto; columna++)
				Console.Write("*");
				Console.WriteLine();
			}
			
	}
}

