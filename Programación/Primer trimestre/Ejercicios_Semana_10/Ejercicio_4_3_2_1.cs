
// Ejercicio 4.3.2.1 - Programa que gestiona canciones con sus datos en un array de estructuras, mostrando al usuario un menú de opciones a realizar

using System;

public class Ejercicio_4_3_2_1
{
	// Estructura para los datos de la canción
	struct cancion
	{
		public string artista;
		public string titulo;
		public int duracion;
		public int tamano;
	}
	
	public static void Main()
	{
		const int MAX_CANCIONES = 100;
		cancion[] canciones = new cancion[MAX_CANCIONES];
		int opcion, posicion, cantidad = 0;
		string textoABuscar;
		bool encontrado;
		
		do
		{
			Console.WriteLine("\nElige una opción:");
			Console.WriteLine("1. Añadir una nueva canción al final");
			Console.WriteLine("2. Insertar una canción en medio");
			Console.WriteLine("3. Borrar una canción de una posición");
			Console.WriteLine("4. Mostrar el listado de canciones");
			Console.WriteLine("5. Buscar canción por título o autor");
			Console.WriteLine("0. Salir del programa");
			
			opcion = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			
			switch(opcion)
			{
				//================================= Caso 1: Añadir un dato al final ====================================
				case 1:
					if (cantidad == MAX_CANCIONES)
					{
						Console.WriteLine("No se pueden añadir más datos");
					} else {
						Console.WriteLine("Escribe el artista de la canción");
						canciones[cantidad].artista = Console.ReadLine();
						Console.WriteLine("Escribe el título de la canción");
						canciones[cantidad].titulo = Console.ReadLine();
						Console.WriteLine("Escribe la duración en segundos");
						canciones[cantidad].duracion = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Escribe el tamaño en KB");
						canciones[cantidad].tamano = Convert.ToInt32(Console.ReadLine());
						cantidad++;
					}
					break;
				//================================= Caso 2: Insertar un dato en medio ====================================
				case 2:
					if (cantidad == MAX_CANCIONES)
					{
						Console.WriteLine("No se pueden añadir más datos");
					} else if (cantidad == 0) {
						Console.WriteLine("El array aún no tiene datos. No se puede añadir en medio");
					} else {
						Console.WriteLine("Indica en qué posición quieres añadir la canción (desde 1 hasta {0})", cantidad);
						posicion = Convert.ToInt32(Console.ReadLine());
						if (posicion < 1 || posicion > cantidad)
						{
							Console.WriteLine("Posición incorrecta");
						} else {
							// Desplazamos a la derecha todos los datos desde cantidad hasta posicion
							for (int i = cantidad; i >= posicion; i--)
							{
								canciones[i] = canciones[i-1];
							}
							// Colocamos la nueva canción en la posición indicada
							Console.WriteLine("Escribe el artista de la canción");
							canciones[posicion-1].artista = Console.ReadLine();
							Console.WriteLine("Escribe el título de la canción");
							canciones[posicion-1].titulo = Console.ReadLine();
							Console.WriteLine("Escribe la duración en segundos");
							canciones[posicion-1].duracion = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("Escribe el tamaño en KB");
							canciones[posicion-1].tamano = Convert.ToInt32(Console.ReadLine());
							cantidad++;
						}
					}
					break;
				//================================= Caso 3: Borrar un dato de una posición ====================================
				case 3:
					if (cantidad == 0) {
						Console.WriteLine("El array aún no tiene nombres. No se puede borrar");
					} else {
						Console.WriteLine("Indica de qué posición quieres borrar la canción (desde 1 hasta {0})", cantidad);
						posicion = Convert.ToInt32(Console.ReadLine());
						if (posicion < 1 || posicion > cantidad)
						{
							Console.WriteLine("Posición incorrecta");
						} else {
							// Desplazamos a la izquierda todos los nombres desde posicion hasta cantidad
							for (int i = posicion; i <= cantidad; i++)
							{
								canciones[i-1] = canciones[i];
							}
							cantidad--;
						}
					}
					break;
				//================================= Caso 4: Listado de datos ====================================
				case 4:
					Console.WriteLine("Listado de canciones:");
					for (int i = 0; i < cantidad; i++)
					{
						Console.WriteLine("{0}. {1} / {2} / {3} seg. / {4} KB", i+1, canciones[i].artista, canciones[i].titulo, canciones[i].duracion, canciones[i].tamano);
					}
					Console.WriteLine("Fin.");
					break;
				//================================= Caso 5: Buscar canción ====================================
				case 5:
					Console.WriteLine("Introduce el nombre del autor o del título de canción:");
					textoABuscar = Console.ReadLine();
					encontrado = false;
					for (int i = 0; i < cantidad; i++)
					{
						if (canciones[i].artista == textoABuscar || canciones[i].titulo == textoABuscar)
						{
							encontrado = true;
							Console.WriteLine("{0}. {1} / {2} / {3} seg. / {4} KB", i+1, canciones[i].artista, canciones[i].titulo, canciones[i].duracion, canciones[i].tamano);
						}
					}
					if (!encontrado)
						Console.WriteLine("No se han encontrado coincidencias");
					Console.WriteLine("Fin.");
					break;
				//================================= Caso 0: Salir ====================================
				case 0: 
					break;
				//================================= Otras opciones: incorrectas ====================================
				default: 
					Console.WriteLine("Opción incorrecta");
					break;
			}
			
		} while (opcion != 0);				
	}
}
