
/*(2.2.3.4) Crea un programa que muestre la tabla de multiplicar del 9.*/

using System;

public class Ejercicio_2_2_3_4
{
	public static void Main()
	{
		int numero;
		numero = 9;
		
		for (int i=1; i<=10; i++)
			Console.WriteLine("{0} x {1} = {2}" , numero, i, numero*i);
		}
	}

