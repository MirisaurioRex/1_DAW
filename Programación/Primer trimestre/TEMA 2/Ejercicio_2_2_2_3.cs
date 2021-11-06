
/*(2.2.2.3) Crea un programa que escriba en pantalla los números pares del 26 al 10 
(descendiendo), usando "do..while".*/

using System;

public class Ejercicio_2_2_2_3
{
	public static void Main()
	{
		int n = 26;
		
		do
		{
				Console.WriteLine(n);
				n = n-2;
			
			}
		while (n >= 10);
		
	}
}
