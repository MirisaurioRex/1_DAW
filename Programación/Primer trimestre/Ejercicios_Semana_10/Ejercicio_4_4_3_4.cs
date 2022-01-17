
// Ejercicio 4.4.3.4 - Programa que le pide al usuario dos números largos en forma de cadena (string) y los suma

using System;

public class Ejercicio_4_4_3_4
{
	public static void Main()
	{
		string num1, num2, resultado;
		int cifra1, cifra2;				// Estas variables las usaremos para convertir a entero cada cifra que analicemos de cada número, posición por posición
		int pos1, pos2;					// Estas variables las usaremos para ir moviéndonos por cada número, desde el final hasta el principio, e irlos sumando cifra a cifra
		int llevamos = 0;				// Esta variable la usaremos para aquellas sumas en que nos "llevamos" algo para sumar en la columna siguiente
		
		Console.WriteLine("Dime un número largo:");
		num1 = Console.ReadLine();
		Console.WriteLine("Dime otro número largo:");
		num2 = Console.ReadLine();
		
		resultado = "";
		
		pos1 = num1.Length-1;
		pos2 = num2.Length-1;
		
		while (pos1 >= 0 || pos2 >= 0)
		{
			// Nos quedamos con la cifra que toca de cada número, siempre que sigan teniendo cifras (si no, contamos que hay un 0)
			cifra1 = (pos1 >= 0) ? Convert.ToInt32(Convert.ToString(num1[pos1])) : 0;
			cifra2 = (pos2 >= 0) ? Convert.ToInt32(Convert.ToString(num2[pos2])) : 0;
			
			// Si nos vamos a pasar de 10 al sumar, entonces nos llevaremos 1 y nos quedaremos con el resto	
			if (cifra1 + cifra2 + llevamos >= 10)
			{
				resultado = ((cifra1 + cifra2 + llevamos) % 10) + resultado;
				llevamos = 1;
			// Si no llegamos a 10, entonces directamente ponemos la suma de las cifras más lo que nos llevábamos de antes
			} else {
				resultado = (cifra1 + cifra2 + llevamos) + resultado;
				llevamos = 0;
			}
			
			// Pasamos a la siguiente cifra
			if (pos1 >= 0) pos1--;
			if (pos2 >= 0) pos2--;
		}		
		
		// Si al final nos llevábamos algo, debemos ponerlo para completar el resultado
		if (llevamos == 1)
		{
			resultado = llevamos + resultado;
		}
		
		Console.WriteLine("Resultado:\n{0}", resultado);
	}
}
