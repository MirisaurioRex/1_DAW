
/*(2.2.1.2.3) Crea un programa calcule cuantas cifras tiene un número entero 
positivo (pista: se puede hacer dividiendo varias veces entre 10).*/

using System;

public class Ejercicio_2_2_1_2_3
{
	public static void Main()
	{
		//introducimos las variables
		int n = 1;
		int n1;
		
		Console.WriteLine("introduce un número positivo");
		n1 = Convert.ToInt32(Console.ReadLine());
		
		while (n1/10 != 0){
			
			n1= n1/10;
			n++;
			
		}
		Console.WriteLine(n);
	}
}
