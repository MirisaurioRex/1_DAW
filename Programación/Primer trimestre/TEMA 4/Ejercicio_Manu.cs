using System;

public class Ejercicio_Menu
{
	public static void Main ()
	{
		
		//Vamos a hacer un menú con varias opciones para el usuario
		
		const int TOTAL = 100; //valor muy grande para nuestro array
		
		double [] listaDatos = new double [TOTAL]; //array de doubles
		string opcion; //para seleccionar la opción
		int cantidad = 0;
		
		
		do { //opciones disponibles en nuestro menú
			Console.WriteLine("Escoge una opción");
			Console.WriteLine("1- Ver datos");
			Console.WriteLine("2- Añadir datos");
			Console.WriteLine("3- Insertar datos en una posición determinada");
			Console.WriteLine("4- Borrar datos en una posición determinada");
			Console.WriteLine("0- Salir");
			
			opcion = Console.ReadLine(); //leemos la opción marcada. A partir de 3 opciones ya se recomienda hacer un switch.
			
			switch (opcion)
				{
					case "1":
						for (int i = 0; i < cantidad; i++) {
						Console.Write(listaDatos[i]+ "  ");
						}
						Console.WriteLine();
						break;
						
					case "2":
						if (cantidad < TOTAL) {
							Console.Write("Dime un dato tipo double escrito como XX,XX: ");
							double dato = Convert.ToDouble(Console.ReadLine());
							listaDatos[cantidad] = dato;
							cantidad++;
						}
						break;
						
						case "3":
							Console.WriteLine("Elige la posición donde quieres insertar un dato nuevo: ");
							int posicionInsertar = Convert.ToInt32(Console.ReadLine());
							
							for (int i = cantidad; i > posicionInsertar; i--) {
								listaDatos[i] = listaDatos[i-1];
						}
							Console.WriteLine("Introduce un valor a insertar: ");
							double valorInsertado = Convert.ToDouble(Console.ReadLine());
							listaDatos [posicionInsertar] = valorInsertado;
							
							cantidad++;
							break;
						
						case "4":
							Console.WriteLine("Elige la posición donde quieres borrar un dato: ");
							int posicionBorrar = Convert.ToInt32(Console.ReadLine());
							
							if (posicionBorrar < cantidad) {
								for (int i = posicionBorrar; i < cantidad-1; i++) {
									listaDatos[i] = listaDatos[i+1];
								}
								Console.WriteLine("El valor {0} en la posicion {1} ha sido borrado", listaDatos[posicionBorrar], posicionBorrar+1);
								cantidad--;
							}
							else 
								Console.WriteLine("La posición no puede ser borrada porque no está registrada");
							break;
				}
		}
		while (opcion != "0");
			Console.WriteLine("Fin del programa");
	}
}
