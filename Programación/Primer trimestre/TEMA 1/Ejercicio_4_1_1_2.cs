/* (4.1.1.1) Un programa que pida al usuario 4 números, los memorice (utilizando un 
array), calcule su media aritmética y después muestre en pantalla la media y los 
datos tecleados.
  */

using System;

public class Ejercicio_4_1_1_2
{
	public static void Main()
	{
			float [] numeros = new float [5];

			for (int i=0; i<numeros.Length;i++) {
				Console.Write("Dime un número: ");
					numeros [i] = Convert.ToInt32(Console.ReadLine());
			}
				for (int i=numeros.Length-1; i>=0; i--) {
					Console.WriteLine(numeros[i]);
			}
	}
}
