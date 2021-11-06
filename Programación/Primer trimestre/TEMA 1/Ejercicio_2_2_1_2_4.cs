
/*2.2.1.2.4) Haz un programa que muestre tantos asteriscos (en la misma línea) 
como indique el usuario.*/

using System;

	public class Ejercicio_2_2_1_2_4
{
	public static void Main()
	{
		//introducimos las variables
		int n = 0 ;
		int n1;
		
		Console.WriteLine("introduce un número positivo");
		n1 = Convert.ToInt32(Console.ReadLine());
		
		while (n <= n1){
			Console.Write("*");
			n = n+1; 
		}
		
	}
}
