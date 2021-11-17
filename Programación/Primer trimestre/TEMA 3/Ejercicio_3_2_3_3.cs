
/*(3.2.3.3) Halla las soluciones de una ecuación de segundo grado del tipo y = Ax2 + Bx + C. Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x) */

using System;

public class Ejercicio_3_2_3_3
{
	public static void Main()
	{
		double A= 2;
		double B= 1;
		double C= 3;
		double x = Math.Sqrt(2);
		double y= A*x + B*x + C;
		
		Console.WriteLine("El resultado es "+ y );
		
	}
}
