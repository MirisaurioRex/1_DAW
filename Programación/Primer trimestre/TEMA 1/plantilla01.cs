
/*(2.2.1.1.4) Crea una versión mejorada del programa anterior, que, tras introducir 
cada par de números, responderá si el primero es múltiplo del segundo, o el 
segundo es múltiplo del primero, o ninguno de ellos es múltiplo del otro.*/

using System;

public class Ejercicio_2_2_1_1_4
{
	public static void Main()
	{
		int n1;
		int n2;
		
		Console.WriteLine("Introduce el primer número");
		n1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Introduce el segundo número");
		n2 = Convert.ToInt32(Console.ReadLine());
	}
}
