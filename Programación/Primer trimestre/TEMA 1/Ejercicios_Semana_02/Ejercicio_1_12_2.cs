
// Ejercicio 1.12.2 - Pedirle al usuario un número y sacar su tabla de multiplicar usando la nomenclatura {0}, {1}, etc.

using System;

public class Ejercicio_1_12_2
{
	public static void Main()
	{
		int numero;

		Console.WriteLine("Dime un número:");
		numero = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("{0} x {1} = {2}", numero, 0, numero*0);
		Console.WriteLine("{0} x {1} = {2}", numero, 1, numero*1);
		Console.WriteLine("{0} x {1} = {2}", numero, 2, numero*2);
		Console.WriteLine("{0} x {1} = {2}", numero, 3, numero*3);
		Console.WriteLine("{0} x {1} = {2}", numero, 4, numero*4);
		Console.WriteLine("{0} x {1} = {2}", numero, 5, numero*5);
		Console.WriteLine("{0} x {1} = {2}", numero, 6, numero*6);
		Console.WriteLine("{0} x {1} = {2}", numero, 7, numero*7);
		Console.WriteLine("{0} x {1} = {2}", numero, 8, numero*8);
		Console.WriteLine("{0} x {1} = {2}", numero, 9, numero*9);
		Console.WriteLine("{0} x {1} = {2}", numero, 10, numero*10);
	}
}
