
/*(2.2.5.2) Crea un programa escriba 4 veces los números del 1 al 5, en una misma 
línea, usando "while": 12345123451234512345.*/

using System;

public class Ejercicio_2_2_5_2
{
	public static void Main()
	{
		int veces = 1;
		
		while (veces <= 4) {
			Console.Write("12345");
			veces++;
		}
		
	}
}

