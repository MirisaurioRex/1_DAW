/* (4.1.1.1) Un programa que pida al usuario 4 números, los memorice (utilizando un 
array), calcule su media aritmética y después muestre en pantalla la media y los 
datos tecleados.
  */

using System;

public class Ejercicio_4_1_1_1
{
	public static void Main()
	{
			int [] numeros = new int [4];
			
			int media;
			
			for (int i=0; i<numeros.Length;i++) {
				Console.Write("Dime un número: ");
				numeros [i] = Convert.ToInt32(Console.ReadLine());
			}

			media = (numeros [0] + numeros [1] + numeros [2] + numeros [3])/4;
			
			Console.WriteLine( "los números tecleados son: " + String.Join(", ", numeros) + " y su media es " + media);
	}
}
