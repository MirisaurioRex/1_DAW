
/*(3.1.6.1) Crea un programa que pida al número del 0 al 255 y muestre el resultado 
de hacer un XOR con un cierto dato prefijado (y también en ese rango). 
Comprueba que la operación es reversible (por ejemplo, 131 xor 5 = 134, y 134 xor 
5 = 131).*/

using System;

public class Ejercicio_2_2_1_1_4
{
	public static void Main()
	{
		byte n = 134;
		byte n2;
		
		Console.Write("Di un número del 0 al 255: ");
		n2 = Convert.ToByte(Console.ReadLine());
		
		
		Console.WriteLine("El suma exclusiva de {0} y {1} es {2}", n, n2, n^n2);
	}
}
