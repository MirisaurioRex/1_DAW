/* (5.5.1) Crea una función "PedirEntero", que reciba como parámetros el texto que 
se debe mostrar en pantalla, el valor mínimo aceptable y el valor máximo 
aceptable. Esta función deberá pedir al usuario que introduzca el valor, tantas 
veces como sea necesario, deberá volvérselo a pedir en caso de error, y deberá 
devolver un valor correcto. Pruébalo con un programa que pida al usuario un año 
entre 1800 y 2100. */

using System;

public class Ejercicio_5_5_1
{
	
	static bool ComprobarRango (int num, int numMin, int numMax) 
	{
		return (num >= numMin && num <= numMax);
	}
	static int PedirEntero (string texto, int numMax, int numMin) 
	{
		int num;
		do
		{
			Console.WriteLine(texto);
			num = Convert.ToInt32(Console.ReadLine());
			if (ComprobarRango (num,  numMin, numMax))
				{
					Console.WriteLine("El número introducido es correcto");
				}
			else
				{
					Console.WriteLine("El número introducido es incorrecto");
				}
		} 
		//while (num < numMin || num > numMax);
		while (!(ComprobarRango  (num, numMin, numMax)));
		
		return num;
	}
	
	public static void Main()
	{
		int numMax = 2100, numMin = 1800;
		string texto = "Adivina en qué rango está el año: ";		
		
		Console.WriteLine("El año introducido es: {0}", PedirEntero(texto, numMax, numMin));
		
		
	} // fin del Main
}
