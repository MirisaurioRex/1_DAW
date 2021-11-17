
/*(3.2.7.3) Crea un programa que calcule la distancia entre dos puntos (x1,y1) y (x2,y2), 
usando la expresión d = raíz [ (x1-x2)2+ (y1-y2)2].

 */

using System;

public class Ejercicio_3_2_7_3
{
	public static void Main()
	{
		double x1 = 2;
		double x2 = 5;
		
		double y1 = 5;
		double y2 = 3;
		double distancia;
		double raiz;
		
		raiz = ((Math.Pow ((x1-x2), 2)) + (Math.Pow((y1-y2), 2)));
		distancia = Math.Sqrt(raiz);
		Console.Write(distancia);
	}
}
