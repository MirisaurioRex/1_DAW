
/*(3.2.6.1) Crea un programa que pida números (en base 10) al usuario y muestre su 
equivalente en sistema binario y en hexadecimal. Debe repetirse hasta que el 
usuario introduzca el número 0.
 */

using System;

public class Ejercicio_3_2_6_1
{
	public static void Main()
	{
		int numero;
		
		do {
			
			Console.Write("Di números y haremos sus conversiones (0 para salir): ");
			numero = Convert.ToInt32(Console.ReadLine());
			
			if (numero!= 0) {
				Console.WriteLine( Convert.ToString(numero, 16) );
				Console.WriteLine( Convert.ToString(numero, 2) );
			}
			else 
				Console.WriteLine("El número es 0");
		}
		while (numero != 0);
	}
}
