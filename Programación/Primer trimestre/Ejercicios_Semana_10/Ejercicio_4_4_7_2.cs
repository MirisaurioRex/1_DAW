
// Ejercicio 4.4.7.2 - Programa que le pide al usuario varios números separados por espacios y calcula su suma

using System;

public class Ejercicio_4_4_7_2
{
	public static void Main()
	{
		string numeros;
		string[] numerosSeparados;
		int suma = 0;
		
		Console.WriteLine("Dime varios números enteros separados por espacios:");
		numeros = Console.ReadLine();
		// Separamos la lista de números por cada espacio y la guardamos en un array
		numerosSeparados = numeros.Split(' ');
		
		// Recorremos el array, convertimos cada número a entero y lo acumulamos en la suma
		for (int i = 0; i < numerosSeparados.Length; i++)
		{
			suma +=	Convert.ToInt32(numerosSeparados[i]);	
		}
		Console.WriteLine("La suma es {0}", suma);
	}
}
