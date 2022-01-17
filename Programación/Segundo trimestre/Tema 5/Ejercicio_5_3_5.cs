/*  (5.4.1) Crea una función "Cubo" que calcule el cubo de un número real (float) que 
se indique como parámetro. El resultado deberá ser otro número real. Prueba esta 
función para calcular el cubo de 3.2 y el de 5.*/

using System;

public class Ejercicio_5_4_1
{
	
	public static float Cubo(float n)
	{
		return n*n*n;
	}
	
	public static void Main()
	{
		float resultado;
		resultado = Cubo (2.3f);
		Console.WriteLine(resultado);
	} // fin del Main
}
