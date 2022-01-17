using System;

public class Prueba
{
	struct ubicacion //datos del sitio donde está el mueble
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
		public ubicacion ubicacionProducto; 
	}
	public static void Main()
	{
		const int TOTAL = 100;
		mueble [] listaCompra = new mueble [TOTAL];
		mueble muebleSolicitado;
		int cantidadProductos = 0;
		string datoSolicitado, opcion;
		float floatSolicitado, suma;
		byte byteSolicitado;
		
		/*
		 variables de prueba
		mueble producto0, producto1, producto2, producto3, producto4;
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
		
		cantidadProductos = 5;
		listaCompra [0] = producto0;
		listaCompra [1] = producto1;
		listaCompra [2] = producto2;
		listaCompra [3] = producto3;
		listaCompra [4] = producto4;
		
		*/
		do
		{
			// menu de opciones
			Console.WriteLine ("Seleccione una de las siguientes opciones: ");
			Console.WriteLine("1- Añadir un producto");
			Console.WriteLine("2- Borrar un producto");
			Console.WriteLine("3- Buscar un producto");
			Console.WriteLine("4- Ordenar un producto");
			Console.WriteLine("5- Calcular el valor de la cesta de la compra");
			Console.WriteLine("6- Salir del programa");
			
			opcion = Console.ReadLine();
		} while (opcion != "6")
		
		//pedir datos al usuario
		
		//pedir código
		
		//pedir descripcion
		
		//pedir marca
		
		//pedir precio
		
		//convertir string a float
		
		//validar float
		
		//pedir seccion
		
		//convertir string a byte
		
		//validar byte
		
		//validar rango correcto
		
		//pedir pasillo
		
		//convertir string a byte
		
		//validar byte
		
		//validar rango correcto
		
		//añadir mueble al array
	
	} //Fin del Main
}
