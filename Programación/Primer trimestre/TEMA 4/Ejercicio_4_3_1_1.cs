using System;

public class Ejercicio_4_3_3_1
{
	public static void Main ()
	{
		
		string nombre;
		Console.WriteLine("Cómo te llamas?");
		nombre = Console.ReadLine();
		
		Console.WriteLine("La inicial de {0} es {1}", nombre, nombre[0]);
		int longitud = nombre.Length;
		
		for (int i = longitud; i >= 0; i--) {
			Console.Write(nombre[i] + " ");
		}
			
	} //fin del main
}

