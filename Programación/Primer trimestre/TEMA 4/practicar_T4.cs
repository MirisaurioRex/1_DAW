using System;

public class Practicar_T4
{
	struct ubicacionMueble //datos del sitio donde está el mueble
	{
		public byte seccion;
		public byte pasillo;
	}
	struct mueble //datos del mueble
	{
		public string codigo;
		public string descripcion;
		public string marca;
		public float precio;
		public ubicacionMueble sitio; 
	}
	public static void Main()
	{
		const int TOTAL = 100; //máximo de muebles en nuestro array
		mueble [] listaCompra = new mueble [TOTAL]; //array de hasta 100 muebles
		mueble muebleSolicitado;
		int cantidadProductos = 0, productoEncontrado;
		string opcion, datoSolicitado;
		float suma = 0, floatSolicitado;
		byte byteSolicitado;
		
		//variables de prueba
		/*mueble producto0;
		producto0.codigo = "213.121.55";
		producto0.descripcion = "Mesa noche";
		producto0.marca = "OXBERG";
		producto0.precio= 4.44f;
		producto0.sitio.pasillo = 22;
		producto0.sitio.seccion = 2;
		
		cantidadProductos = 1;
		listaCompra [0] = producto0;
		*/
		//fin de variables de prueba
		
		do  
		{ 	// menu de opciones
			Console.WriteLine ("Seleccione una de las siguientes opciones: ");
			Console.WriteLine("1- Añadir un producto");
			Console.WriteLine("2- Borrar un producto");
			Console.WriteLine("3- Buscar un producto");
			Console.WriteLine("4- Ordenar un producto");
			Console.WriteLine("5- Calcular el valor de la cesta de la compra");
			Console.WriteLine("6- Salir del programa");
			
			opcion = Console.ReadLine();
			
			switch (opcion)
			{
				case "1": //añadir un producto
					// comprobar que hay hueco en el array
					if (cantidadProductos<TOTAL)
					{	//pedir los datos y comprobarlos
						do 
						{
							Console.Write("Introduce el código del producto: ");
								datoSolicitado = Console.ReadLine();
								
						} while (datoSolicitado == "");
							muebleSolicitado.codigo = datoSolicitado;
						
						do 
						{
							Console.Write("Introduce la descripción del producto: ");
								datoSolicitado = Console.ReadLine();
								
						} while (datoSolicitado == "");
							muebleSolicitado.descripcion = datoSolicitado;
							
						do 
						{
							Console.Write("Introduce la marca del producto: ");
								datoSolicitado = Console.ReadLine().ToUpper();
								
						} while (datoSolicitado == "");
							muebleSolicitado.marca = datoSolicitado;	
						
						do 
						{
							Console.Write("Introduce el precio del producto: ");
								datoSolicitado = Console.ReadLine();
							try
							{
								floatSolicitado = Convert.ToSingle(datoSolicitado);
							}
							catch (Exception errorEncontrado)
							{
								floatSolicitado = 0;
								datoSolicitado = "";
								Console.WriteLine("Introduzca un valor numérico válido");
							}
						} while (datoSolicitado == "");
							muebleSolicitado.precio = floatSolicitado;
						
						do 
						{
							Console.Write("Introduce la ubicacion (pasillo) del producto: ");
								datoSolicitado = Console.ReadLine();
							try
								{
									byteSolicitado = Convert.ToByte(datoSolicitado);
								}
								catch (Exception errorEncontrado)
								{
									byteSolicitado = 0;
									datoSolicitado = "";
									Console.WriteLine("Introduzca un valor numérico válido");
								}
						} while (datoSolicitado == "");
							muebleSolicitado.sitio.pasillo = byteSolicitado;
							
						do 
						{
							Console.Write("Introduce la ubicacion (sección) del producto: ");
								datoSolicitado = Console.ReadLine();
								try
								{
									byteSolicitado = Convert.ToByte(datoSolicitado);
								}
								catch (Exception errorEncontrado)
								{
									byteSolicitado = 0;
									datoSolicitado = "";
									Console.WriteLine("Introduzca un valor numérico válido");
								}
						} while (datoSolicitado == "" || byteSolicitado ==0);
							muebleSolicitado.sitio.seccion = byteSolicitado;	
							
							//sumar +1 al listado de productos
							listaCompra[cantidadProductos] = muebleSolicitado;
							cantidadProductos++;
					}
				break;
				
				case "2": //Borrar un producto
					productoEncontrado = -1;
					
					// comprobamos que haya productos
					if (cantidadProductos <= 0)
					{
						Console.WriteLine("No hay productos en la lista que poder borrar");
					}
					//mostrar productos
					else
					{
						for (int i = 0; i < cantidadProductos; i++)
						{
							Console.WriteLine((i+1) +" --" + listaCompra[i].codigo +" --" + listaCompra[i].descripcion +" --" + listaCompra[i].marca);
						}
					}
					//pedir codigo del producto a borrar
					Console.WriteLine("Introduce el código del producto que deseas borrar");
					datoSolicitado = Console.ReadLine();
					//comprobar que el codigo está en la lista
					for (int i = 0; i < cantidadProductos; i++)
					{
						if (datoSolicitado == listaCompra[i].codigo)
						{
							productoEncontrado = i; //obtener posición
						}
					}
					if (productoEncontrado != -1)
					{ //borrar dicha posición y colocar los datos
						for (int i = productoEncontrado; i < cantidadProductos-1; i++)
						{
							listaCompra[i] = listaCompra[i+1];
						}
						cantidadProductos--;
					}
					else
					{
						Console.WriteLine("Producto no encontrado");
					}
					//mensaje borrado exitoso
				
				break;
				
				case "3": //Buscar un producto
					//pedir descripcion al usuario
					productoEncontrado = -1;
					
					Console.WriteLine("Introduce ela descripción del producto que deseas borrar: ");
					datoSolicitado = Console.ReadLine();
					//comprobar que la descripción está en la lista
					for (int i = 0; i < cantidadProductos; i++)
					{
						
						if (listaCompra[i].descripcion.ToUpper().Contains(datoSolicitado.ToUpper()))
						{
							productoEncontrado = 1;
							Console.WriteLine((i+1)+ " -- "+ listaCompra[i].codigo+" -- "+listaCompra[i].descripcion+" -- "+listaCompra[i].marca+ " -- "+listaCompra[i].precio);
						}
					}
					if (productoEncontrado != -1) //si no hay coincidencias mostrar mensaje
					{
						Console.WriteLine("Producto no encontrado");
					}
					
				break;
				
				case "4": //Ordenar un producto
					//nos preparamos una variable auxialiar
					datoTemporal
					//ordenar productos con método burbuja
					for (int i = 0; i < cantidadProducto-1; i++)
					{
						for (j = i+1; j < cantidadProducto; j++)
						{
							if (listaCompra[i]>listaCompra[j])
								if (listaCompra[i].sitio.seccion > listaCompra[j].sitio.seccion)
								{
									_
								}
							{
								datoTemporal = listaCompra [i];
								listaCompra[i] = listaCompra[j];
								listaCompra[j] = datoTemporal;
							}
						}
					}
					
				break;
				
				case "5": //Calcular  total de la cesta de la compra
				
				break;
				
				case "6": //Salir del programa
					Console.WriteLine("Fin del programa");
				break;
				
				default:
					Console.WriteLine("Opción no válida!");
				break;
			}//fin del switch
		}//fin del do
		while (opcion != "6"); //el bucle se repetirá hasta que se pulse el 6 en el menú
			
	}// fin main
}
