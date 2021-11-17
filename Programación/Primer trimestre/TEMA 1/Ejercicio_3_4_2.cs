/* (3.5.1) Crea un programa que use el operador condicional para dar a una variable 
llamada "iguales" (booleana) el valor "true" si los dos números que ha tecleado el 
usuario son iguales, o "false" si son distintos.
  */

using System;

public class Ejercicio_3_5_1
{
	public static void Main()
	{
			int n1, n2;
			bool iguales;
			
			Console.Write("Introduce un número: ");
				n1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Introduce un número: ");
				n2 = Convert.ToInt32(Console.ReadLine());
			
			iguales = (n1==n2);
			
			if (iguales) {
				
				Console.WriteLine("Los números son iguales");
			}
			else
				Console.WriteLine("Los números son distintos");
	}
}
