
/*(2.1.1.2) Crea un programa que pida al usuario dos números enteros y diga cuál es
el mayor de ellos.*/

using System;

public class Ejercicio_2_1_1_2
{
	public static void Main()
	{
		int numero1;
		int numero2;
		
		Console.WriteLine("Dime un número");
				numero1 = Convert.ToInt32(Console.ReadLine());
				
		Console.WriteLine("Dime otro número");
				numero2 = Convert.ToInt32(Console.ReadLine());

		if (numero1 > numero2) 
			Console.WriteLine("{0} es mayor que {1}", numero1, numero2);
		else
			Console.WriteLine("{0} es menor que {1}", numero1, numero2);
	}
}
