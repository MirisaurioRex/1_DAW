
/*(2.2.5.1) Crea un programa escriba 4 veces los números del 1 al 5, en una misma 
línea, usando "for": 12345123451234512345.*/

using System;

public class Ejercicio_2_2_5_1
{
	public static void Main()
	{
		int contar;
		
		for (int i = 1; i <= 4; i++ ) {
			for (contar =1; contar <= 5; contar++)
				Console.Write(contar);
			}
		
		
	}
}

