/*
 * Practica Evaluable Tema 4
 * Ejercicio 1
 * 
 * Programa que gestiona un array de objetos definidos mediante
 * una estructura (struct), permitiendo añadir, borrar, buscar y 
 * ordenar
 */

using System;

public class TiendaMuebles
{
	struct ubicacionProducto
	{
		public byte pasillo;
		public byte seccion;
	}
	
	struct producto
	{
		public string codigo;
		public string descripcion;
		public string marca;
		public float precio;
		public ubicacionProducto ubicacion;
	}
	
	public static void Main()
	{
		const byte MAXIMO = 100;
		
		sbyte cantidad = 0, opcionMenu;
		int i, j;
		float totalComprado;
		string codigoABorrar, textoABuscar;
		bool encontrado;
		producto[] compras = new producto[MAXIMO];
				
		do
		{	
			// Esta instrucción no se ha visto aún, pero se puede utilizar		
			Console.Clear();
			
			Console.WriteLine ("Menú de opciones:");
			Console.WriteLine ("1 - Añadir un producto");
			Console.WriteLine ("2 - Borrar un producto");
			Console.WriteLine ("3 - Buscar un producto");
			Console.WriteLine ("4 - Ordenar productos");
			Console.WriteLine ("5 - Calcular importe");
			Console.WriteLine ("0 - Salir");
			Console.WriteLine();
			
			Console.Write ("Elige opción : ");
			try
			{
				opcionMenu = Convert.ToSByte(Console.ReadLine());
				if ((opcionMenu < 0) || (opcionMenu > 5))
					opcionMenu = -1;	// Opción incorrecta
			} 
			catch (FormatException)
			{
				opcionMenu = -1;		// Opción incorrecta
			}		

			switch (opcionMenu)
			{
				case 0:  // Salir

					break;
					
				case 1:  // Añadir producto

					Console.Clear();
					
					if (cantidad < MAXIMO)
					{					
						Console.WriteLine("Introduzca datos del nuevo producto:");
						
						do
						{
							Console.Write("Código producto: ");
							compras[cantidad].codigo = Console.ReadLine();
						} while (compras[cantidad].codigo == "");

						do
						{
							Console.Write("Descripción: ");
							compras[cantidad].descripcion = Console.ReadLine();
						} while (compras[cantidad].descripcion == "");

						do
						{
							Console.Write("Marca: ");
							compras[cantidad].marca  = Console.ReadLine().ToUpper();
						} while (compras[cantidad].marca == "");

						do
						{
							try
							{
								Console.Write("Precio : ");
								compras[cantidad].precio = Convert.ToSingle(Console.ReadLine());
							}
							catch (FormatException)
							{
								compras[cantidad].precio = -1;
							}							
						} while (compras[cantidad].precio <= 0);

						do 
						{
							try
							{
								Console.Write("Ubicacion (Pasillo) 0-50 : ");
								compras[cantidad].ubicacion.pasillo = Convert.ToByte(Console.ReadLine());
							}
							catch (Exception)
							{
								compras[cantidad].ubicacion.pasillo = 100;
							}
						} while(compras[cantidad].ubicacion.pasillo < 0 || compras[cantidad].ubicacion.pasillo > 50);

						do
						{
							try
							{
								Console.Write("Ubicacion (Seccion) 0-40 : ");
								compras[cantidad].ubicacion.seccion = Convert.ToByte(Console.ReadLine());
							}
							catch (Exception)
							{
								compras[cantidad].ubicacion.seccion = 100;
							}
						} while(compras[cantidad].ubicacion.seccion < 0 || compras[cantidad].ubicacion.seccion > 40);
				
						cantidad++;  
						
						Console.WriteLine("Producto añadido correctamente");    
					}
					else
					{
						Console.WriteLine("No se pueden almacenar más datos");
					}
					
					break;
					
				case 2: // Borrar un producto
				
					Console.Clear();
					
					if (cantidad > 0)
					{
						for (i = 0; i < cantidad; i++)
						{
							Console.WriteLine (compras[i].codigo + 
								" " + compras[i].descripcion + 
								" " + compras[i].marca);
						}
						
						Console.Write ("Indique el código a borrar : ");
						codigoABorrar = Console.ReadLine();
						
						i = 0;
						encontrado = false;
						while (i < cantidad && !encontrado)
						{
							if (compras[i].codigo == codigoABorrar)
								encontrado = true;
							else
								i++;
						}
						
						if (encontrado)
						{
							for (j = i; j < cantidad; j++)
							{
								// Se pueden mover en bloque structs enteros
								compras[j] = compras[j+1];
							}
							
							cantidad--;						

							Console.WriteLine("Producto borrado");												
						} 
						else 
						{
							Console.WriteLine("Producto no encontrado");
						}
					}
					else
					{
						Console.WriteLine("No existen datos que borrar");
					}
												
					break;
					
				case 3: // Buscar por descripción

					Console.Clear();

					Console.Write ("Introduce palabra a buscar en descripción: ");
					textoABuscar = Console.ReadLine();
					
					encontrado = false;
					for (i = 0; i < cantidad; i++)
					{
						if (compras[i].descripcion.ToUpper().Contains(textoABuscar.ToUpper()))
						{
							encontrado = true;
							Console.WriteLine("{0} {1} {2} {3}Euros",compras[i].codigo,
								compras[i].descripcion,compras[i].marca,compras[i].precio);
						}
					}
					
					if (!encontrado)
					{
						Console.WriteLine("No se encontraron productos");
					}
					
					break;
					
				case 4:  // Ordenar productos
				
					for (i = 0; i < cantidad - 1; i++)
					{
						for (j = i + 1; j < cantidad; j++)
						{
							if (compras[i].ubicacion.pasillo > compras[j].ubicacion.pasillo) 
							{
								// Ordena por pasillo
								producto aux = compras[i];
								compras[i] = compras[j];
								compras[j] = aux;								
							}
							else if (compras[i].ubicacion.pasillo == compras[j].ubicacion.pasillo &&
							         compras[i].ubicacion.seccion > compras[j].ubicacion.seccion)  
							{
								// En el caso de que los pasillos coincidan, ordena por sección	
								producto aux = compras[i];
								compras[i] = compras[j];
								compras[j] = aux;	

							} 
						}
					}
					for (i = 0; i < cantidad; i++)
					{
						Console.WriteLine("{0} {1} {2} {3} (pasillo {4} seccion {5})", compras[i].codigo,
							compras[i].descripcion, compras[i].marca, compras[i].precio.ToString("0.00"),
							compras[i].ubicacion.pasillo.ToString("00"),
							compras[i].ubicacion.seccion.ToString("00"));
					}
										
					break;
				
				case 5:  // Suma de los productos comprados

					Console.Clear();
				
					totalComprado = 0;
					for (i = 0; i < cantidad; i++)
					{
						totalComprado += compras[i].precio;
					}
					
					Console.WriteLine("El importe es : {0} euros",totalComprado.ToString("0.00"));

					break;
					
				default :
				
					Console.Clear();
					
					Console.WriteLine("Opción incorrecta");

					break;			
			}
			
			Console.WriteLine("Pulse Intro para continuar");
			Console.ReadLine();			
			
		} while(opcionMenu != 0);
	}
}
