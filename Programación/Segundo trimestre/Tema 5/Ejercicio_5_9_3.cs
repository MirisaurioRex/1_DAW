/* (5.9.3) Crea un programa que emplee recursividad para calcular un número de la 
serie Fibonacci (en la que los dos primeros elementos valen 1, y para los restantes, 
cada elemento es la suma de los dos anteriores).*/

using System;

public class Ejercicio_5_9_3
{
	static int Fibonacci (int a)
	{
		if (a < 0)
			return 1;
			
		return Fibonacci(a-1 + a-2);
		
	}
	
	public static void Main()
	{
		Console.WriteLine(Fibonacci (5));
		
	} // fin del Main
}
