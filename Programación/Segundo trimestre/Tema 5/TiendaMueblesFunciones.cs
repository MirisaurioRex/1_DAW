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
*/

using System;

public class TiendaMueblesFunciones
{
    //struct para los registros
    public struct ubicacion
    {
        public byte pasillo;
        public byte seccion;
    }
    public struct fabricante
    {
        public string fabricanteNombre;
        public string idFabricante;
        public string telFabricante;
    }
    public struct tipoMueble
    {
        public string codigoProducto;
        public string descripcion;
        public string marca;
        public float precio;

        public fabricante fabricanteProducto;
        public ubicacion ubicacionProducto;
    }

    public static string Opciones()
    {

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
    public static ubicacion CrearUbicacion()
    {

        ubicacion miUbicacion;
        string stringSolicitado;
        byte byteSolicitado;
        do
        {
            Console.WriteLine("Introduzca el pasillo del producto:");
            stringSolicitado = Console.ReadLine();
            try
            {
                byteSolicitado = Convert.ToByte(stringSolicitado);
            }
            catch (Exception errorEncontrado)
            {
                byteSolicitado = 0;
                stringSolicitado = "";
                Console.WriteLine("Introduzca un valor numérico válido");
            }
            //validar pasillo
            if (byteSolicitado < 0 || byteSolicitado > 50)
            {
                Console.WriteLine("Número de pasillo no válido");
                stringSolicitado = "";
            }
        }
        while (stringSolicitado == "");
        miUbicacion.pasillo = byteSolicitado;

        do
        {
            Console.WriteLine("Introduzca la sección del producto:");
            stringSolicitado = Console.ReadLine();
            try
            {
                byteSolicitado = Convert.ToByte(stringSolicitado);
            }
            catch (Exception errorEncontrado)
            {
                byteSolicitado = 0;
                stringSolicitado = "";
                Console.WriteLine("Introduzca un valor numérico válido");
            }
            //validar seccion
            if (byteSolicitado < 0 || byteSolicitado > 40)
            {
                Console.WriteLine("Número de seccion no válido");
                stringSolicitado = "";
            }
        }
        while (stringSolicitado == "");
        miUbicacion.seccion = byteSolicitado;

        return miUbicacion;
    }
    public static fabricante CrearFabricante()
    {
        fabricante miFabricante;
        string stringSolicitado;

        do
        {
            Console.WriteLine("Introduzca el fabricante del producto:");
            stringSolicitado = Console.ReadLine();
        }
        while (stringSolicitado == "");
        miFabricante.fabricanteNombre = stringSolicitado;

        do
        {
            Console.WriteLine("Introduzca el identificador del fabricante del producto:");
            stringSolicitado = Console.ReadLine();
        }
        while (stringSolicitado == "");
        miFabricante.idFabricante = stringSolicitado;

        do
        {
            Console.WriteLine("Introduzca el teléfono del fabricante del producto:");
            stringSolicitado = Console.ReadLine();
        }
        while (stringSolicitado == "");
        miFabricante.telFabricante = stringSolicitado;

        return miFabricante;
    } //fin CrearFabricante

    public static Boolean ComprobarCodProducto(tipoMueble[] array, string codigo)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].codigoProducto == codigo)
            {
                return false;
            }
        }
        return true;
    }
    public static tipoMueble CrearTipoMueble(tipoMueble[] listaCompra)
    {
        tipoMueble tipoMuebleSolicitado;
        string stringSolicitado;
        float floatSolicitado;
        //pedimos todos los datos y comprobar que sean correctos
        do
        {

            Console.WriteLine("Introduzca el código del producto:");
            stringSolicitado = Console.ReadLine();
            if (!ComprobarCodProducto(listaCompra, stringSolicitado))
            {
                Console.WriteLine("El código del producto ya existe, insértelo de nuevo");
                stringSolicitado = "";
            }
        }
        while (stringSolicitado == "");
        tipoMuebleSolicitado.codigoProducto = stringSolicitado;

        do
        {
            Console.WriteLine("Introduzca la descripción del producto:");
            stringSolicitado = Console.ReadLine();
        }
        while (stringSolicitado == "");
        tipoMuebleSolicitado.descripcion = stringSolicitado;

        do
        {
            Console.WriteLine("Introduzca la marca del producto:");
            stringSolicitado = Console.ReadLine().ToUpper();
        }
        while (stringSolicitado == "");
        tipoMuebleSolicitado.marca = stringSolicitado;

        do
        {
            Console.WriteLine("Introduzca el precio del producto:");
            stringSolicitado = Console.ReadLine();
            try
            {
                floatSolicitado = Convert.ToSingle(stringSolicitado);
            }
            catch (Exception errorEncontrado)
            {
                floatSolicitado = 0;
                stringSolicitado = "";
                Console.WriteLine("Introduzca un valor numérico válido");
            }
        }
        while (stringSolicitado == "");
        tipoMuebleSolicitado.precio = floatSolicitado;

        tipoMuebleSolicitado.ubicacionProducto = CrearUbicacion();
        tipoMuebleSolicitado.fabricanteProducto = CrearFabricante();

        return tipoMuebleSolicitado;
    }// fin CrearMueble

    public static void Añadir(ref tipoMueble[] listaCompra, ref int contador)
    {
        Console.Clear();
        //comprobar que hay hueco en el array
        if (contador < listaCompra.Length)
        {
            //añadimos el nuevo dato a la array
            listaCompra[contador] = CrearTipoMueble(listaCompra);
            contador++;
        }
    }//fin Añadir

    public static Boolean BorrarAux(ref tipoMueble[] listaCompra, ref int contador, string stringSolicitado)
    {
        bool encontrado = false;
        int indiceBorrado = -1;
        //comprobar si ese código está dentro del array
        for (int i = 0; i < contador; i++)
        {
            if (stringSolicitado == listaCompra[i].codigoProducto)
                encontrado = true;
            indiceBorrado = i;
            //si hubiesen dos códigos répetidos, solo borraría el último encontrado
        }
        if (encontrado)
        {
            //si está, desplazar los productos a la izquierda
            for (int i = indiceBorrado; i < contador - 1; i++)
            {
                listaCompra[i] = listaCompra[i + 1];
            }
            contador--;
        }
        return encontrado;
    }//Fin BorrarAux
    public static void Borrar(ref tipoMueble[] listaCompra, ref int contador)
    {
        Console.Clear();

        string stringSolicitado;
        //mostrar todos los productos
        if (contador == 0)
            Console.WriteLine("No hay productos en la lista");
        else
        {
            Mostrar(listaCompra, contador);
            //solicitar el código del producto a borrar
            Console.WriteLine("Introduzca el código del producto a borrar:");
            stringSolicitado = Console.ReadLine();

            if (BorrarAux(ref listaCompra, ref contador, stringSolicitado))
            {
                Console.WriteLine("El producto ha sido borrado con éxito");
            }
            else
            {
                Console.WriteLine("Producto no encontrado");
            }
        }
    }// fin Borrar

    public static string OpcionesOrdenar()
    {
        string datoOrdenar;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Escoja una opción de ordenación:");
            Console.WriteLine("1 - Para ordenar por marca de producto");
            Console.WriteLine("2 - Para ordenar por código de producto");
            Console.WriteLine("3 - Para ordenar por precio de producto");
            datoOrdenar = Console.ReadLine();

            switch (datoOrdenar)
            {
                case "1":
                    return "marca";

                case "2":
                    return "codigo";

                case "3":
                    return "precio";

            }
        }
        while (datoOrdenar != "1" && datoOrdenar != "2" && datoOrdenar != "3");
        return Console.ReadLine();


    }//
    public static void Ordenar(ref tipoMueble[] listaCompra, ref int contador, string datoOrdenar = "marca")
    {
        Console.Clear();

        tipoMueble datoTemporal;
        float datoTemporalFloat;

        switch (datoOrdenar)
        {
            case "marca":
                {
                    for (int i = 0; i < contador - 1; i++)
                    {
                        for (int j = i + 1; j < contador; j++)
                        {
                            ///String.Compare devuelve <0 en caso de A mayor q B, 0 si son iguales y >0 si B es mayor q A
                            if (String.Compare(listaCompra[i].marca, listaCompra[j].marca) > 0)
                            {

                                datoTemporal = listaCompra[i];
                                listaCompra[i] = listaCompra[j];
                                listaCompra[j] = datoTemporal;
                            }
                        }
                    }
                    break;
                }
            case "codigo":
                {
                    for (int i = 0; i < contador - 1; i++)
                    {
                        for (int j = i + 1; j < contador; j++)
                        {
                            //Esto se ordenará como string, siendo 100<2
                            if (String.Compare(listaCompra[i].codigoProducto, listaCompra[j].codigoProducto) > 0)
                            {

                                datoTemporal = listaCompra[i];
                                listaCompra[i] = listaCompra[j];
                                listaCompra[j] = datoTemporal;
                            }
                        }
                    }
                    break;
                }
            case "precio":
                {
                    for (int i = 0; i < contador - 1; i++)
                    {
                        for (int j = i + 1; j < contador; j++)
                        {
                            if (listaCompra[i].precio < listaCompra[j].precio)
                            {

                                datoTemporal = listaCompra[i];
                                listaCompra[i] = listaCompra[j];
                                listaCompra[j] = datoTemporal;
                            }
                        }
                    }
                    break;
                }
        }
    }// fin Ordenar

    public static void Buscar(ref tipoMueble[] listaCompra, ref int contador)
    {
        Console.Clear();

        string campoOrd = OpcionesOrdenar();
        Ordenar(ref listaCompra, ref contador, campoOrd);
        string busqueda;

        Console.WriteLine("Introduzca la búsqueda deseada");
        busqueda = Console.ReadLine();
        int valorBusqueda = BusquedaRecursiva(listaCompra, busqueda, campoOrd, 0, contador);

        if (valorBusqueda != -1)
        {
            MostrarMueble(listaCompra[valorBusqueda]);
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }

    }// fin Buscar
    public static int BusquedaRecursiva(tipoMueble[] listaCompra, string busqueda, string campoBuscar, int izquierda, int derecha)
    {
        if (izquierda > derecha) return -1; //devolvemos -1 si no encontramos el dato buscado

        int indiceDeLaMitad = (izquierda + derecha) / 2;
        string valorMedio = "";

        switch (campoBuscar)
        {
            case "marca":
                valorMedio = listaCompra[indiceDeLaMitad].marca;
                break;

            case "codigo":
                valorMedio = listaCompra[indiceDeLaMitad].codigoProducto;
                break;

        }
        if (String.Compare(busqueda, valorMedio) == 0)
        {
            return indiceDeLaMitad;
        }

        if (String.Compare(busqueda, valorMedio) < 0)
        {
            // Entonces está hacia la izquierda
            derecha = indiceDeLaMitad - 1;
        }
        else
        {
            // Está hacia la derecha
            izquierda = indiceDeLaMitad + 1;
        }
        return BusquedaRecursiva(listaCompra, busqueda, campoBuscar, izquierda, derecha);
    }//fin BusquedaRecursiva

    public static void MostrarMueble(tipoMueble miMueble)
    {
        Console.WriteLine(miMueble.codigoProducto + " -- " + miMueble.descripcion + " -- " + miMueble.marca +
                        " -- " + miMueble.precio + " -- " + miMueble.fabricanteProducto.fabricanteNombre + " -- " + miMueble.fabricanteProducto.idFabricante +
                        " -- " + miMueble.fabricanteProducto.telFabricante + " -- " + miMueble.ubicacionProducto.pasillo + " -- " + miMueble.ubicacionProducto.seccion);

    }

    public static void Mostrar(tipoMueble[] listaMueble, int contador)
    {
        //mostrar listado de productos
        for (int i = 0; i < contador; i++)
        {
            MostrarMueble(listaMueble[i]);
        }
    }
    public static void CalcularImporte(tipoMueble[] listaCompra, int contador)
    {
        Console.Clear();

        float suma = 0;
        if (contador == 0)
            Console.WriteLine("No hay productos en la lista");
        else
        {
            //suma de los productos
            for (int i = 0; i < contador; i++)
            {
                suma += listaCompra[i].precio;
            }
            Console.WriteLine("La suma de los productos es {0} pesetas", suma);
        }
    }
    public static void Main()
    {
        const int MAXIMO = 250;
        tipoMueble[] listaCompra = new tipoMueble[MAXIMO];
        int productosEnLista = 0;
        string opcion;

        //variables de prueba
        tipoMueble producto0, producto1, producto2, producto3, producto4;
        producto0.codigoProducto = "213.121.55";
        producto0.descripcion = "Mesa noche";
        producto0.marca = "OXBERG";
        producto0.precio = 4.44f;
        producto0.ubicacionProducto.pasillo = 22;
        producto0.ubicacionProducto.seccion = 2;
        producto0.fabricanteProducto.fabricanteNombre = "IKEA";
        producto0.fabricanteProducto.idFabricante = "1548";
        producto0.fabricanteProducto.telFabricante = "946153486";

        producto1.codigoProducto = "232.551.22";
        producto1.descripcion = "Estantería";
        producto1.marca = "BILLY";
        producto1.precio = 5.10f;
        producto1.ubicacionProducto.pasillo = 15;
        producto1.ubicacionProducto.seccion = 9;
        producto1.fabricanteProducto.fabricanteNombre = "IKEA";
        producto1.fabricanteProducto.idFabricante = "845";
        producto1.fabricanteProducto.telFabricante = "946153286";

        producto2.codigoProducto = "112.242.55";
        producto2.descripcion = "Silla";
        producto2.marca = "EKEDALEN";
        producto2.precio = 8.9f;
        producto2.ubicacionProducto.pasillo = 15;
        producto2.ubicacionProducto.seccion = 3;
        producto2.fabricanteProducto.fabricanteNombre = "IKEA";
        producto2.fabricanteProducto.idFabricante = "1558";
        producto2.fabricanteProducto.telFabricante = "946153454";

        producto3.codigoProducto = "112.242.44";
        producto3.descripcion = "Silla noche";
        producto3.marca = "EKEDALENIS";
        producto3.precio = 3.90f;
        producto3.ubicacionProducto.pasillo = 15;
        producto3.ubicacionProducto.seccion = 8;
        producto3.fabricanteProducto.fabricanteNombre = "IKEA";
        producto3.fabricanteProducto.idFabricante = "1118";
        producto3.fabricanteProducto.telFabricante = "941153486";

        producto4.codigoProducto = "115.242.55";
        producto4.descripcion = "Mesa comedor";
        producto4.marca = "BONG";
        producto4.precio = 111.49f;
        producto4.ubicacionProducto.pasillo = 22;
        producto4.ubicacionProducto.seccion = 17;
        producto4.fabricanteProducto.fabricanteNombre = "IKEA";
        producto4.fabricanteProducto.idFabricante = "15482";
        producto4.fabricanteProducto.telFabricante = "946153412";

        productosEnLista = 5;
        listaCompra[0] = producto0;
        listaCompra[1] = producto1;
        listaCompra[2] = producto2;
        listaCompra[3] = producto3;
        listaCompra[4] = producto4;

        //fin de variables de prueba

        do
        {
            opcion = Opciones();

            switch (opcion)
            {
                case "1": // añadimos un producto
                    Añadir(ref listaCompra, ref productosEnLista);
                    break;

                case "2": // borrar un producto
                    Borrar(ref listaCompra, ref productosEnLista);
                    break;

                case "3": // buscar un productor
                    Buscar(ref listaCompra, ref productosEnLista);
                    break;

                case "4": //ordenar productos
                    Ordenar(ref listaCompra, ref productosEnLista, "marca");
                    break;

                case "5": //calcular importe
                    CalcularImporte(listaCompra, productosEnLista);
                    break;

                case "6": // salir del programa
                    Console.Clear();
                    Console.WriteLine("-- Fin del programa --");
                    break;

                default: // opción no válida
                    Console.Clear();
                    Console.WriteLine("** Opción desconocida! **");
                    break;
            }
        } while (opcion != "6"); // Si la opcion es 6, terminamos

    }
}
