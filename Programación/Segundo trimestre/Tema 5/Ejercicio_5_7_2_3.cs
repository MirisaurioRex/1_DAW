/* (5.7.2.3) Crea una función "MaxMinArray", que reciba un array de reales de doble 
precisión y devuelva el mayor valor almacenado en ese array y el menor, utilizando 
parámetros por referencia. Pruébala con un "Main" adecuado.*/

using System;

public class Ejercicio_5_7_2_3
{
	static void MaxMinArray (int[] datos, ref int minimo, ref int maximo)
	{
		minimo = datos[0];
		maximo = datos[0];
		
		for (int i = 0; i < datos.Length; i++)
		{
			if (datos[i] < minimo)
			{
				minimo = datos[i];
			}
		}
		for (int i = 0; i < datos.Length; i++)
		{
			if (datos[i] > maximo)
			{
				maximo = datos[i];
			}
		}
		
	}
	
	
	public static void Main()
	{
		int[] numeros = {5, 3, -1, 17, 0, 20};
		int min = 0, max = 0;
		MaxMinArray (numeros, ref min, ref max);
		Console.WriteLine(min + " " + max);
		
	} // fin del Main
}
