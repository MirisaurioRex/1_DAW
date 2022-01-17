/*Miranda Azorín Vidal
	Examen Eva 1
	Ejercicio 1
	Apartado 1.1 si
	Apartado 1.2 si
	Apartado 1.3 si
	Apartado 1.4 si
	Apartado 1.5 si
	Apartado 1.6 si
	Apartado 1.7 si
*/

using System;

public class Ejercicio_1
{
	struct restaurante  //hacemos la estructura
		{
			public string nombre;
			public string ciudad;
			public byte tenedores; 
			public float precioMedio;
		}
	public static void Main()
	{
		const int TOTAL = 80;
		restaurante [] restaurantes = new restaurante [TOTAL]; //hacemos el array
		restaurante tipoRestaurante;
		string opcion, datoSolicitado; //declaramos las variables que vamos a usar
		float floatSolicitado;
		byte byteSolicitado;
		int cantidad = 0, datoEncontrado =-1;
		int sitioBorrado;
		
		
		 //*restaurantes de prueba
		
		/*cantidad = 2;
		restaurantes[0].nombre = "ABAC";
		restaurantes[0].ciudad = "Barcelona";
		restaurantes[0].tenedores = 5;
		restaurantes[0].precioMedio = 555f;
		
		restaurantes[1].nombre = "Torrezno";
		restaurantes[1].ciudad = "Baca";
		restaurantes[1].tenedores = 1;
		restaurantes[1].precioMedio = 45.2f;
		*/
		*// restaurantes de prueba
		 
		
		do
		{ 	//hacemos el menú
			Console.WriteLine();
			Console.WriteLine ("1- Añadir nuevo restaurante");
			Console.WriteLine ("2- Borrar un restaurante");
			Console.WriteLine ("3- Buscar por ciudad");
			Console.WriteLine ("4- Buscar precio mínimo");
			Console.WriteLine ("5- salir");
			
			opcion = Console.ReadLine(); //leemos la opcion elegida
			
			switch (opcion)
			{
				case "1": //añadir un nuevo restaurante
					//comprobar que hay hueco en el array
					if (cantidad < TOTAL)
					{
						//solicitar los datos 
						Console.WriteLine("Añade el nombre del restaurante: "); //nombre
							datoSolicitado = Console.ReadLine();
							tipoRestaurante.nombre = datoSolicitado;
							
						Console.WriteLine("Añade la ciudad del restaurante: "); //ciudad
							datoSolicitado = Console.ReadLine();
							tipoRestaurante.ciudad = datoSolicitado;
							
						Console.WriteLine("Añade el número de tenedores del restaurante: ");//tenedores
							byteSolicitado = Convert.ToByte(Console.ReadLine());
							
							if ((byteSolicitado >= 1) && (byteSolicitado <= 5)) {
								tipoRestaurante.tenedores = byteSolicitado;	
							}
							else
							{
								Console.WriteLine("El número de tenedores es incorrecto, intruduzca un valor entre 1 y 5");
							}
						
						Console.WriteLine("Añade el precio medio del restaurante: "); //precio
							try
							{
								floatSolicitado = Convert.ToSingle(Console.ReadLine());
							}
							catch (Exception errorEncontrado)
							{
								floatSolicitado = 0;
								Console.WriteLine("El valor introducido no es válido");
							}
							if (floatSolicitado != 0) {
								tipoRestaurante.precioMedio = floatSolicitado;
							}
							//añadir los datos al array
							tipoRestaurante = restaurantes[cantidad];
							cantidad++;
						}
						else
						{
							Console.WriteLine("No pueden añadirse más restaurantes");
						}
				break;
					
				case "2"://borrar un restaurante
					//Comprobar que hay restaurantes que se puedan borrar
					if (cantidad > 0)
					{
						//mostrar restaurantes
						for (int i = 0; i < cantidad; i++)
						{
							Console.WriteLine((i+1) + " --" + restaurantes[i].nombre + " --" + restaurantes[i].ciudad);
						}
						//pedir restaurante a borrar
						Console.WriteLine("Introduzca la posición del restaurante que desea borrar");
						sitioBorrado = Convert.ToInt32(Console.ReadLine());
						
						for (int i = sitioBorrado-1; i < cantidad; i++)
						{
							restaurantes[i] = restaurantes[i+1];
						}
						Console.WriteLine("El restaurante ha sido borrado con éxito");
						//habrá un restaurante menos
						cantidad--;
					}
					break;
					
				case "3"://buscar por ciudad
					//Comprobar que hay restaurantes que se puedan buscar
					if (cantidad > 0)
						{
							Console.WriteLine("Introduzca el texto a buscar"); //pedir el texto a buscar
							datoSolicitado = Console.ReadLine();
							
							if (datoSolicitado != "") //que el texto no esté vacío
							{
								for (int i = 0; i < cantidad; i++)
								{ 
									 if(restaurantes[i].ciudad.ToUpper().Contains(datoSolicitado.ToUpper())) //pasamos los datos a mayúsculas para ver si coincide algo
									{
										datoEncontrado = 0;
										Console.WriteLine(restaurantes[i].nombre + "--" + restaurantes[i].ciudad);
									}
								}
								if (datoEncontrado != 0)
								{
									Console.WriteLine("No se han encontrado coincidencias");
								}
							}
						}
					break;
					
				case "4": //buscar precio mínimo
				float min = restaurantes[0].precioMedio;
					//Comprobar que hay restaurantes que se puedan borrar
					if (cantidad > 0)
						{
							for (int i = 1; i < cantidad; i++) //buscar a partir del siguiente dato si hay mínimos 
							{
								if (restaurantes[i].precioMedio < restaurantes[0].precioMedio)
								{
									min = restaurantes[i].precioMedio;
								}
							}
							Console.WriteLine("El restaurante con menor precio es {0}", min.ToString("0.00"));
						}
					break;
					
				case "5":
					Console.WriteLine("Fin del programa.");
					break;
					
				default:
					Console.WriteLine("Opción no válida!");
				break;
			}
		} 
		while (opcion !="5"); //fin del programa
		
	} // fin del Main
}


