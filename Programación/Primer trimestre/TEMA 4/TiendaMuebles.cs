/*  Azorín Vidal, Miranda
Practica Evaluable Tema 4
Ejercicio 1
Apartado 1.1 si 
Apartado 1.2 si 
Apartado 1.3 si 
Apartado 1.4 si  
Apartado 1.5 si
Apartado 1.6 si
Apartado 1.7 si
Apartado 1.8 si
Apartado 1.9 si
Apartado 1.10 si
*/

using System;

public class TiendaMuebles
{
	//struct para los registros
	struct ubicacion {
		public byte pasillo;
		public byte seccion;
	}
	struct tipoMueble {
		public string codigoProducto;
		public string descripcion;
		public string marca;
		public float precio;
		public  ubicacion ubicacionProducto;
	}
	
	public static string  muestraMenu() {
			 Console.WriteLine();
			 Console.WriteLine("Escoja una opción:");
			 Console.WriteLine("1.- Añadir un producto");
			 Console.WriteLine("2.- Borrar un producto");
			 Console.WriteLine("3.- Buscar un producto");
			 Console.WriteLine("4.- Ordenar productos");
			 Console.WriteLine("5.- Calcular importe");
			 Console.WriteLine("6.- Salir");
			 
			 return Console.ReadLine();
	}	
	
	
	public static void Main()
	{
		const int MAXIMO = 100;
		tipoMueble [] listaCompra = new tipoMueble[MAXIMO];
		int productosEnLista = 0;
		tipoMueble tipoMuebleSolicitado;
		string opcion, stringSolicitado;
		float floatSolicitado;
		float suma = 0;
		byte byteSolicitado;
		int indiceBorrado = -1;
		byte datoTemporal;
		
		//variables de prueba
		tipoMueble producto0, producto1, producto2, producto3, producto4;
		producto0.codigoProducto = "213.121.55";
		producto0.descripcion = "Mesa noche";
		producto0.marca = "OXBERG";
		producto0.precio= 4.44f;
		producto0.ubicacionProducto.pasillo = 22;
		producto0.ubicacionProducto.seccion = 2;
		
		producto1.codigoProducto = "232.551.22";
		producto1.descripcion = "Estantería";
		producto1.marca = "BILLY";
		producto1.precio= 5.10f;
		producto1.ubicacionProducto.pasillo = 15;
		producto1.ubicacionProducto.seccion = 9;
		
		producto2.codigoProducto = "112.242.55";
		producto2.descripcion = "Silla";
		producto2.marca = "EKEDALEN";
		producto2.precio= 8.9f;
		producto2.ubicacionProducto.pasillo = 15;
		producto2.ubicacionProducto.seccion = 3;
		
		producto3.codigoProducto = "112.242.44";
		producto3.descripcion = "Silla noche";
		producto3.marca = "EKEDALENIS";
		producto3.precio= 3.90f;
		producto3.ubicacionProducto.pasillo = 15;
		producto3.ubicacionProducto.seccion = 8;
		
		producto4.codigoProducto = "115.242.55";
		producto4.descripcion = "Mesa comedor";
		producto4.marca = "BONG";
		producto4.precio= 111.49f;
		producto4.ubicacionProducto.pasillo = 22;
		producto4.ubicacionProducto.seccion = 17;
		
		productosEnLista = 5;
		listaCompra [0] = producto0;
		listaCompra [1] = producto1;
		listaCompra [2] = producto2;
		listaCompra [3] = producto3;
		listaCompra [4] = producto4;
		
		//fin de variables de prueba
		
		do {
		 // 
		 
			 opcion =  muestraMenu();
			 
			 // 
			 switch(opcion) {
				 
				 case "1": // añadimos un producto
				 
					//comprobar que hay hueco en el array
					if (productosEnLista<MAXIMO) {
						//pedimos todos los datos y comprobar que sean correctos
						do {
							Console.WriteLine("Introduzca el código del producto:");
							stringSolicitado = Console.ReadLine();
						}
						while (stringSolicitado == "");
						tipoMuebleSolicitado.codigoProducto = stringSolicitado;
						
						do {
							Console.WriteLine("Introduzca el descripción del producto:");
							stringSolicitado = Console.ReadLine();
						}
						while (stringSolicitado == "");
						tipoMuebleSolicitado.descripcion = stringSolicitado;
						
						do {
							Console.WriteLine("Introduzca la marca del producto:");
							stringSolicitado = Console.ReadLine().ToUpper();
						}
						while (stringSolicitado == "");
						tipoMuebleSolicitado.marca = stringSolicitado;
						
						do {
							Console.WriteLine("Introduzca el precio del producto:");
							stringSolicitado = Console.ReadLine();
							try {
								floatSolicitado = Convert.ToSingle(stringSolicitado);
							} catch (Exception errorEncontrado) {
								floatSolicitado = 0;
								stringSolicitado = "";
								Console.WriteLine("Introduzca un valor numérico válido");
							}
						}
						while (stringSolicitado == "");
						tipoMuebleSolicitado.precio = floatSolicitado;
							
						do {
							Console.WriteLine("Introduzca el pasillo del producto:");
							stringSolicitado = Console.ReadLine();
							try {
								byteSolicitado = Convert.ToByte(stringSolicitado);
							} catch (Exception errorEncontrado) {
								byteSolicitado = 0;
								stringSolicitado = "";
								Console.WriteLine("Introduzca un valor numérico válido");
							}
							//validar pasillo
							if(byteSolicitado<0 || byteSolicitado>50){
								Console.WriteLine("Número de pasillo no válido");
								stringSolicitado = "";
							}
						}
						while (stringSolicitado == "");
						tipoMuebleSolicitado.ubicacionProducto.pasillo = byteSolicitado;	
						
						do {
							Console.WriteLine("Introduzca la sección del producto:");
							stringSolicitado = Console.ReadLine();
							try {
								byteSolicitado = Convert.ToByte(stringSolicitado);
							} catch (Exception errorEncontrado) {
								byteSolicitado = 0;
								stringSolicitado = "";
								Console.WriteLine("Introduzca un valor numérico válido");
							}
							//validar seccion
							if(byteSolicitado<0 || byteSolicitado>40){
								Console.WriteLine("Número de seccion no válido");
								stringSolicitado = "";
							}
						}
						while (stringSolicitado == "");
						tipoMuebleSolicitado.ubicacionProducto.seccion = byteSolicitado;
						
						//añadimos el nuevo dato a la array
						listaCompra [productosEnLista] = tipoMuebleSolicitado;
						productosEnLista++;
					}
				 break;
				 
				 case "2": // borrar un producto
					bool encontrado = false;
					//mostrar todos los productos
					if (productosEnLista == 0)
						Console.WriteLine("No hay productos en la lista");
					else {
						for (int i=0; i<productosEnLista; i++){
							Console.WriteLine((i+1)+ " -- "+ listaCompra[i].codigoProducto+" -- "+listaCompra[i].descripcion+" -- "+listaCompra[i].marca);
						}
						//solicitar el código del producto a borrar
						Console.WriteLine("Introduzca el código del producto a borrar:");
						stringSolicitado = Console.ReadLine();
					
						//comprobar si ese código está dentro del array
						for (int i=0; i<productosEnLista; i++) {
							if (stringSolicitado == listaCompra[i].codigoProducto)
							encontrado = true;
							indiceBorrado = i;
							//si hubiesen dos códigos répetidos, solo borraría el último encontrado
						}
						if (encontrado) {
							//si está, desplazar los productos a la izquierda
							for (int i= indiceBorrado; i < productosEnLista-1; i++){
								listaCompra[i] = listaCompra[i+1];
							}
							productosEnLista--;
							Console.WriteLine("El producto con código {0} ha sido borrado con éxito", stringSolicitado);
						}
						else {
							Console.WriteLine("Producto no encontrado");
						}
					}
				 
				 break;
				 
				 case "3": // buscar un productor
					
					//mostrar productos que coincidan
					if (productosEnLista == 0) {
						Console.WriteLine("No hay productos en la lista");
					}
					else {
						encontrado = false;
						//solicitar descripción.
						Console.WriteLine("Introduzca la descripción del producto a buscar:");
						stringSolicitado = Console.ReadLine();
						
						for (int i=0; i<productosEnLista; i++) {
								if (listaCompra[i].descripcion.ToUpper().Contains(stringSolicitado.ToUpper())) {
									//en caso de haber tíldes, se tendrá que hacer la búsqueda con tílde
									encontrado = true;
									Console.WriteLine((i+1)+ " -- "+ listaCompra[i].codigoProducto+" -- "+listaCompra[i].descripcion+" -- "+listaCompra[i].marca+ " -- "+listaCompra[i].precio);
							}	
						}
						if (!encontrado)
									Console.WriteLine("No se encontraron productos");
					}
				
				 break;
				 
				 case "4": //ordenar productos
				 
					//ordenar productos por ubicación 
					//ordenado por pasillo
					for(int i=0; i < productosEnLista-1; i++) {
						 for(int j=i+1; j < productosEnLista; j++) {
								 if (listaCompra[i].ubicacionProducto.pasillo > listaCompra[j].ubicacionProducto.pasillo) {
									 
									 datoTemporal = listaCompra[i].ubicacionProducto.pasillo;
									 listaCompra[i].ubicacionProducto.pasillo = listaCompra[j].ubicacionProducto.pasillo;
									 listaCompra[j].ubicacionProducto.pasillo = datoTemporal;
								 }
							 }
						 }
						 
						 //ordenar por sección
						 for(int i=0; i < productosEnLista-1; i++) {
							 for(int j=i+1; j < productosEnLista; j++) {
									 if (listaCompra[i].ubicacionProducto.seccion > listaCompra[j].ubicacionProducto.seccion) {
										 if (listaCompra[i].ubicacionProducto.pasillo == listaCompra[j].ubicacionProducto.pasillo) {
											 datoTemporal = listaCompra[i].ubicacionProducto.seccion;
											 listaCompra[i].ubicacionProducto.seccion = listaCompra[j].ubicacionProducto.seccion;
											 listaCompra[j].ubicacionProducto.seccion = datoTemporal;
										 }
									 }
								 }
							}
						 //mostrar listado de productos
						 for (int i=0; i<productosEnLista; i++) {
							Console.WriteLine((i+1)+ " -- "+ listaCompra[i].codigoProducto+" -- "+listaCompra[i].descripcion+" -- "+listaCompra[i].marca+ 
							" -- "+listaCompra[i].precio+ " -- " +listaCompra[i].ubicacionProducto.pasillo+" -- " +listaCompra[i].ubicacionProducto.seccion);
					}
					
				 break;
				 
				 case "5": //calcular importe
					suma = 0;
					if (productosEnLista == 0)
						Console.WriteLine("No hay productos en la lista");
					else {
						//suma de los productos
						for (int i=0; i<productosEnLista; i++) {
							suma += listaCompra[i].precio;
						}
						Console.WriteLine("La suma de los productos es {0} pesetas", suma);
					}
				 break;
				 
				 case "6": // salir del programa
					Console.WriteLine("Fin del programa");
				 break;
				 
				 default: // opción no válida
					Console.WriteLine("Opción desconocida!");
				 break;
			 }
		 } while (opcion != "6"); // Si la opcion es 6, terminamos
		
	}
}
