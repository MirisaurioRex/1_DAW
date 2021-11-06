
/*Crea un programa que pida al usuario su contraseña (numérica). 
Deberá terminar cuando introduzca como contraseña el número 1111, pero 
volvérsela a pedir tantas veces como sea necesario.*/

using System;

public class Ejercicio_2_2_1_1_1
{
	public static void Main()
	{
	 int contraseña;
	 
		Console.WriteLine("Introduce tu contraseña");
		contraseña = Convert.ToInt32(Console.ReadLine());
		
		if (contraseña == 1111)
				Console.WriteLine("Contraseña correcta");
		
		while (contraseña != 1111)
		{
			if (contraseña == 1111){
				Console.WriteLine("Contraseña correcta");
		}
			else
				{
				Console.WriteLine("Contraseña incorrecta, vuelva a introducirla");
				contraseña = Convert.ToInt32(Console.ReadLine()); 
					}
		}
	}
}
