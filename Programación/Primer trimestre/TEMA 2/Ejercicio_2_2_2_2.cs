
/*(2.2.2.2) Crea un programa que escriba en pantalla los números del 1 al 10, 
usando "do..while".*/

using System;

public class Ejercicio_2_2_2_2
{
	public static void Main()
	{
		int n = 1;
		
		do
		{
				Console.WriteLine(n);
				n = n+1;
			
			}
		while (n <= 10);
		
	}
}
