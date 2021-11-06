
/*(2.1.9.1) Crea un programa que pida un número del 1 al 10 al usuario, y escriba el
nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el
programa escribirá "uno").*/

using System;

public class Ejercicio_2_1_9_1
{
	public static void Main()
	{
	 int n1;
		
		Console.WriteLine("Introduce un número del 1 al 10");
		n1 = Convert.ToInt32(Console.ReadLine());
		
		switch (n1)
			{
				case 1: Console.WriteLine("uno"); break;
				case 2: Console.WriteLine("dos"); break;
				case 3: Console.WriteLine("tres"); break;
				case 4: Console.WriteLine("cuatro"); break;
				case 5: Console.WriteLine("cinco"); break;
				case 6: Console.WriteLine("seis"); break;
				case 7: Console.WriteLine("siete"); break;
				case 8: Console.WriteLine("ocho"); break;
				case 9: Console.WriteLine("nueve"); break;
				case 10: Console.WriteLine("diez"); break;
				
				default: Console.WriteLine("No es un número del 1 al 10"); break;
				}
	}
}
