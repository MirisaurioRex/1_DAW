/*(5.5.3) Crea una función "EsPrimo", que reciba un número y devuelva el valor 
booleano "true" si es un número primo o "false" en caso contrario.*/

using System;

public class Ejercicio_5_5_3
{
	
	static bool EsPrimo (int primo)
	{
		bool esPrimo = true;
		
		for (int i = 2; i <= primo; i++)
		{
			if (primo % i == 0 && primo != i)
			{
				esPrimo = false;
				Console.Write(i + " ");
			}
		}
		
		return esPrimo;
	}
	
	public static void Main()
	{
		int primo;
		Console.WriteLine("Escribe un número y veremos si es primo");
		primo = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine(EsPrimo(primo));
		
	} // fin del Main
}
