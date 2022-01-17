/* (4.1.3.2) Crea un programa que pregunte al usuario cuántos números enteros va a 
introducir (por ejemplo, 10), le pida todos esos números, los guarde en un array y 
finalmente calcule y muestre la media de esos números.
  */

using System;

public class Ejercicio_4_1_3_2
{
	public static void Main()
	{
		int n;
		int suma=0;
		int media;
		
		Console.WriteLine("¿Cuántos números vas a introducir? ");
		n = Convert.ToInt32(Console.ReadLine());
		int [] numeros = new int [n];
		
		for (int i=0; i<n;i++) {
			Console.WriteLine("Introduce el número {0}", i+1);
			numeros [i] = Convert.ToInt32(Console.ReadLine());																							
			suma += numeros [i];
			}
		media = suma/n;
		Console.WriteLine("La media de " + String.Join(", ", numeros) + " es " + media);
	}
}
