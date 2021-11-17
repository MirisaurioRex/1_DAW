/*  ((3.4.2) Crea un programa que pida al usuario un nombre y una contraseña. La 
contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales, se 
avisará al usuario y se le volverán a pedir las dos contraseñas, tantas veces como 
sea necesario hasta que coincidan.  */

using System;

public class Ejercicio_3_4_2
{
	public static void Main()
	{
			string usuario;
			string contrasena;
			string contrasena2;
			
			Console.Write("Introduzca su usuario: ");
				usuario = Console.ReadLine();
			
		do {
				
				Console.Write("Introduzca su contraseña: ");
				contrasena = Console.ReadLine();
			
				Console.Write("Vuelva a introducir su contraseña: ");
				contrasena2 = Console.ReadLine();
				
			if (contrasena == contrasena2) {
				Console.WriteLine("Contraseña correcta");
				
				}
			else 
				Console.WriteLine("Contraseña incorrecta, vuelva a introducir la contraseña");
			}
		while (contrasena != contrasena2);	
	}
}
