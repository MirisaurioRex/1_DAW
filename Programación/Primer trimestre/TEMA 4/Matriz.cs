/*   Azorín Vidal, Miranda
Practica Evaluable Tema 4
Ejercicio 2
Apartado 2.1 si 
Apartado 2.2 si 
Apartado 2.3 si 
Apartado 2.4 si
*/

using System;

public class Matriz
{
	public static void Main()
	{
		const int FILA = 4;
		const int COLUMNA = 6;
		int numeroSolicitado = -1;
		bool numeroValido = false;
		int minimo = 0;
		int maximo = 0;
		bool numeroValidoEncontrado = false;
		
		int [,] miMatriz = new int [FILA,COLUMNA];
		int [] minimoFila = new int [FILA];
		int [] maximoColumna = new int [COLUMNA];
		
		//matrices de prueba
		/*int [,] miMatriz = 
		{	
			{1, 3, 3, 4, 5, 1},
			{5, 2, 7, 8, 1, 10},
			{20, 10, 30, 50, 80, 70},
			{13, 4, 11, 2, 4, 6},
		};*/
		/*int [,] miMatriz = 
		{	
			{14, 22 , 13 , 27},
			{15, 16, 17 , 18},
			{34, 15, 16, 17},
			{44, 25 , 36, 26},
			{12, 15, 16, 17}
		};*/
		/*int [,] miMatriz = 
		{	
			{5, 2, 6, -8, 2},
			{3, -5, 9, 14 , 23},
			{-56, 34, 23, 67, 5},
			{-6, 2, 0, 5, -7},
		};*/
		
		
		//Recorremos el array añadiendo los datos uno por uno
		for (int i=0; i<FILA; i++) {
			for (int j=0; j<COLUMNA; j++) {
				numeroValido = false;
				Console.WriteLine("Introduzca el valor {0}, {1}: ", (i+1), (j+1));
				
				do {
					try { //comprobamos que el dato introducido sea correcto
					numeroSolicitado = Convert.ToInt32(Console.ReadLine());
					miMatriz [i,j] = numeroSolicitado;
					numeroValido = true;
					} catch  (Exception errorEncontrado) {
						Console.WriteLine("El número introducido no es válido. Introduzca otro número");
					}
				} while (!numeroValido);
			}
		}
		//búsqueda del mínimo de cada fila
		for (int i=0; i<FILA; i++) {
			for (int j=0; j<COLUMNA; j++) {
				if (j == 0)
					minimo = miMatriz[i,j];
				if (miMatriz[i,j]<minimo) {
					minimo = miMatriz[i,j];
					}
				}
				minimoFila[i] = minimo;
			}
			
			//comprobación de ordenado correctamente
	/*	for (int i=0; i<FILA; i++) {
			Console.Write(minimoFila[i]+" ");
		}
			Console.WriteLine();*/
		
		//búsqueda del máximo de cada columna
		for (int i=0; i<COLUMNA; i++) {
			for (int j=0; j<FILA; j++) {
				if (j == 0)
					maximo = miMatriz[j,i];
				if (miMatriz[j,i]>maximo) {
					maximo = miMatriz[j,i];
					}
				}
				maximoColumna[i] = maximo;
			}
		
			//comprobación de ordenado correctamente
		/*for (int i=0; i<COLUMNA; i++) {
			Console.Write(maximoColumna[i]+" ");
		}
			Console.WriteLine();	*/
		
		//comparación de números mínimos y máximos
		for (int i=0; i<FILA; i++) {
			for (int j=0; j<COLUMNA; j++) {
				if (minimoFila[i] == maximoColumna[j]) {
					numeroValidoEncontrado = true;
					Console.WriteLine("Elemento {0} en la posición [{1},{2}]", minimoFila[i], i+1, j+1);
				}
			}
		}
		if (!numeroValidoEncontrado)
			Console.WriteLine("No se han encontrado elementos que cumplan la condición");
	}
}
