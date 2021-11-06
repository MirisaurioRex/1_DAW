
// Ejercicio 2.1.9.1 - Uso de switch para pedirle al usuario un número del 1 al 10 y escribirlo en letra ("uno", "dos", etc.)

using System;

public class Ejercicio_2_1_9_1
{
	public static void Main()
	{
		int numero;
		
		Console.WriteLine("Dime un número:");
		numero = Convert.ToInt32(Console.ReadLine());
		
		switch (numero)
		{
			case 1: Console.WriteLine("Uno");
					break;
			case 2: Console.WriteLine("Dos");
					break;
			case 3: Console.WriteLine("Tres");
					break;
			case 4: Console.WriteLine("Cuatro");
					break;
			case 5: Console.WriteLine("Cinco");
					break;
			case 6: Console.WriteLine("Seis");
					break;
			case 7: Console.WriteLine("Siete");
					break;
			case 8: Console.WriteLine("Ocho");
					break;
			case 9: Console.WriteLine("Nueve");
					break;
			case 10: Console.WriteLine("Diez");
					break;
			default: Console.WriteLine("No es uno de los números esperados");
					break;
		}
	}
}
