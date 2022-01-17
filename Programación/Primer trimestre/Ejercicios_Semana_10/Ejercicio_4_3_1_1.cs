
// Ejercicio 4.3.1.1 - Programa que crea una estructura o registro con los datos de una canción, le pide los datos de ésta al usuario y los muestra por pantalla

using System;

public class Ejercicio_4_3_1_1
{
	struct cancion
	{
		public string artista;
		public string titulo;
		public int duracion;
		public int tamano;
	}
	
	public static void Main()
	{
		cancion c;
		
		Console.WriteLine("Dime los datos de la canción");
		Console.Write("Artista: ");
		c.artista = Console.ReadLine();
		Console.Write("Titulo: ");
		c.titulo = Console.ReadLine();
		Console.Write("Duración (en segundos): ");
		c.duracion = Convert.ToInt32(Console.ReadLine());
		Console.Write("Tamaño (en KB): ");
		c.tamano = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\nEsto es lo que has introducido:");
		Console.WriteLine("Artista: {0}", c.artista);
		Console.WriteLine("Titulo: {0}", c.titulo);
		Console.WriteLine("Duración: {0} segundos", c.duracion);
		Console.WriteLine("Tamaño: {0} KB", c.tamano);		
	}
}
