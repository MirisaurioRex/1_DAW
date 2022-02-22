/* (5.9.1) Crea una función que calcule el valor de elevar un número entero a otro 
número entero (por ejemplo, 5 elevado a 3 = 53
= 5 ·5 ·5 = 125). Esta función se 
debe crear de forma recursiva. Piensa cuál será el caso base (qué potencia se 
puede calcular de forma trivial) y cómo pasar del caso "n-1" al caso "n" (por 
ejemplo, si sabes el valor de 54
, cómo hallarías el de 55
a partir de él). */

using System;

public class Ejercicio_5_9_1
{
	static int Potencia (int a, int b)
	{
		if (b == 0)
			return 1;
			
		return a * Potencia(a, b-1);
		
	}
	
	public static void Main()
	{
		Console.WriteLine(Potencia (5, 3));
		
	} // fin del Main
}
