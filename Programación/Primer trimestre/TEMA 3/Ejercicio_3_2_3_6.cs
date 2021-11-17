
/*(3.2.3.6) Crea un programa que "dibuje" la gráfica de y = (x-5)2 para valores de x 
entre 1 y 10. Deberá hacerlo dibujando varios espacios en pantalla y luego un 
asterisco. La cantidad de espacios dependerá del valor obtenido para "y". Te será 
fácil si dibujas la gráfica "girada", de forma que los valores de "y" crezcan hacia la 
derecha, así: */

using System;

public class Ejercicio_3_2_3_6
{
	public static void Main()
	{
		double y;

		for (double x = 1; x <=10; x++) {
			y = Math.Pow((x-5), 2);
			for (double i = 0; i<y; i++) {
			Console.Write(" ");
		}
		Console.WriteLine("*");
		}
	}
}
