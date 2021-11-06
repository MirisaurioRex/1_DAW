
/*(2.2.2.4) Crea un programa que pida al usuario su identificador y su contraseña 
(ambos numéricos), y no le permita seguir hasta que introduzca como 
identificador "1234" y como contraseña "1111".*/

using System;

public class Ejercicio_2_2_2_4
{
	public static void Main()
	{
		int identificador = 1234;
		int contraseña = 1111;
		
		do
		{
				Console.WriteLine("Escriba su identificador y contraseña");
				identificador = Convert.ToInt32(Console.ReadLine());
				contraseña = Convert.ToInt32(Console.ReadLine());
				
				if (identificador != 1234 || contraseña != 1111)
					Console.WriteLine("Contraseña o identificador incorrectos");
			
			}
		while (identificador != 1234 && contraseña != 1111);
		
		Console.WriteLine("Contraseña e identificador, correctos");
		
	}
}
